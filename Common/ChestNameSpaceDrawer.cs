namespace MoreInfo.Common
{
    internal class ChestNameSpaceDrawer : ModSystem
    {
        internal struct Container { internal int tileX, tileY, index; internal Color color; internal Container(int x, int y, int i, Color c) { tileX = x; tileY = y; index = i; color = c; } }
        internal List<Container> containersDisplay = new List<Container>();

        public override void Load() {
            base.Load();
            On.Terraria.GameContent.Drawing.TileDrawing.DrawSingleTile += TileDrawing_DrawSingleTile;
            On.Terraria.GameContent.Drawing.TileDrawing.Draw += TileDrawing_Draw;
        }

        public override void Unload() {
            base.Unload();
            On.Terraria.GameContent.Drawing.TileDrawing.DrawSingleTile -= TileDrawing_DrawSingleTile;
            On.Terraria.GameContent.Drawing.TileDrawing.Draw += TileDrawing_Draw;
        }

        private void TileDrawing_Draw(On.Terraria.GameContent.Drawing.TileDrawing.orig_Draw orig, Terraria.GameContent.Drawing.TileDrawing self, bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride) {
            
            orig.Invoke(self, solidLayer, forRenderTargets, intoRenderTargets, waterStyleOverride);

            if (!solidLayer) return; // 为了保证不被单格物块挡住，我们要在solidLayer层绘制

            foreach (var container in containersDisplay) {
                var chest = Main.chest[container.index];
                if (chest == null) continue; // 防止在检测空挡期箱子被挖掉了导致获取不到，这里得加个判定

                var font = FontAssets.MouseText.Value;
                Vector2 screenOffset = new Vector2(Main.offScreenRange, Main.offScreenRange);
                if (Main.drawToScreen)
                    screenOffset = Vector2.Zero;

                if (InfoLoader.GenericConfiguration.ChestNameDisplay) {
                    // 箱子名称
                    string text = chest.name; // 由于名字中可能含有物品代码等等，所以不能用Draw里面的origin了
                    float scale = InfoLoader.GenericConfiguration.ChestNameSize;
                    var offset = ChatManager.GetStringSize(font, text, Vector2.One * scale) / 2f;
                    var pos = new Vector2(container.tileX + 1, container.tileY).ToWorldCoordinates(0, InfoLoader.GenericConfiguration.ChestNameYOffset) - Main.screenPosition + screenOffset - offset;
                    
                    TextSnippet[] snippets = ChatManager.ParseMessage(text, container.color * 1.5f).ToArray();
                    ChatManager.ConvertNormalSnippets(snippets);
                    foreach (var snippet in snippets) { snippet.Scale = scale; }
                    ChatManager.DrawColorCodedStringWithShadow(Main.spriteBatch, font, snippets, pos, 0f, Vector2.Zero, Vector2.One, out _);
                    //ChatManager.DrawColorCodedStringWithShadow(Main.spriteBatch, font, text, pos, container.color * 1.5f, 0f, Vector2.Zero, Vector2.One * scale);
                }

                if (InfoLoader.GenericConfiguration.ChestSpaceDisplay) {
                    // 箱子容量
                    var pos = new Vector2(container.tileX + 1, container.tileY + 2).ToWorldCoordinates(0, 0) - Main.screenPosition + screenOffset;
                    int slotsFilled = 0;
                    foreach (var m in from item in chest.item where item != null && item.type != ItemID.None select item) { slotsFilled++; }
                    string text = $"{slotsFilled}/{chest.item.Length}";
                    var c = container.color.MultiplyRGB(Color.LightGray);
                    if (slotsFilled == chest.item.Length) {
                        text = "Full!";
                        c = container.color.MultiplyRGB(Color.Red);
                    }
                    ChatManager.DrawColorCodedString(Main.spriteBatch, font, text, pos, c, 0f, font.MeasureString(text) / 2f, Vector2.One * 0.76f);
                }
            }

            containersDisplay.Clear();
        }

        private void TileDrawing_DrawSingleTile(On.Terraria.GameContent.Drawing.TileDrawing.orig_DrawSingleTile orig, Terraria.GameContent.Drawing.TileDrawing self, Terraria.DataStructures.TileDrawInfo drawData, bool solidLayer, int waterStyleOverride, Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY) {
            orig.Invoke(self, drawData, solidLayer, waterStyleOverride, screenPosition, screenOffset, tileX, tileY);
            if (!(TileID.Sets.BasicChest[drawData.typeCache] || TileID.Sets.BasicChestFake[drawData.typeCache]) || drawData.tileFrameX % 36 != 0 || drawData.tileFrameY % 36 != 0 || (drawData.tileLight.R < 1 && drawData.tileLight.G < 1 && drawData.tileLight.B < 1))
                return;
            int chest = Chest.FindChest(tileX, tileY);
            if (chest < 0) return;

            // 为了使文本不被物块遮挡，先存起来后面Draw
            containersDisplay.Add(new Container(tileX, tileY, chest, drawData.finalColor));
        }

        public override void PostDrawTiles() {
            base.PostDrawTiles();
        }
    }
}
