namespace Dogs.Domain.Entities
{
    public abstract class BasicEntity
    {
        public int Id {  get; set; }
        public abstract string getInfo();
    }
}
