namespace MoreInfo.DebugInfos
{
    internal abstract class DebugInfo : Info
    {
        protected sealed override void Register() {
            Type = InfoLoader.AddDebug(this);
        }
    }
}