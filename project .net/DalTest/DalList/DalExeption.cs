
namespace Dal
{
    internal class DalIdNotExsist:Exception
    {
        public DalIdNotExsist() :base() { }
        public DalIdNotExsist(string massage):base(massage) { }
        public DalIdNotExsist(string massage,Exception inner_exeption):base(massage,inner_exeption) { }
        

    }
    internal class DalIdExsist:Exception
    {
        public DalIdExsist():base() { }
        public DalIdExsist(string massage):base(massage) { }
        public DalIdExsist(string massage, Exception inner_exeption) : base(massage, inner_exeption) { }

    }
    


}
