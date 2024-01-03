namespace Coree.Entities
{
  public  class Owner :EntityBase
    {
        public string FullName { get; set; }
        public string  Portfolio { get; set; }
        public string  Avatar { get; set; }
        public Address Address { get; set; }

    }

}
