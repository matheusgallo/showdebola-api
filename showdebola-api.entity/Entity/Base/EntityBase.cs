namespace showdebola_api.entity.Entity.Base
{
    public abstract class EntityBase
    {
        protected long id { get; set; }
        protected DateTime created { get; set; }
        protected DateTime? updated { get; set; }
    }
}
