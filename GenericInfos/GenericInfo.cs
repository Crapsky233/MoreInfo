namespace MoreInfo.GenericInfos
{
    internal abstract class GenericInfo : Info
    {
        protected sealed override void Register() {
            Type = InfoLoader.AddGeneric(this);
        }
    }
}