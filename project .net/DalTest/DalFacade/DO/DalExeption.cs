
namespace Dal
{
    public class DalIdNotExsist:Exception
    {
        public DalIdNotExsist() :base() { }
        public DalIdNotExsist(string massage):base(massage) { }
        public DalIdNotExsist(string massage,Exception inner_exeption):base(massage,inner_exeption) { }
        

    }
    public class DalIdExsist:Exception
    {
        public DalIdExsist():base() { }
        public DalIdExsist(string massage):base(massage) { }
        public DalIdExsist(string massage, Exception inner_exeption) : base(massage, inner_exeption) { }

    }
    public class DalFileNotExsist : Exception
    {
        public DalFileNotExsist() : base() { }
        public DalFileNotExsist(string massage) : base(massage) { }
        public DalFileNotExsist(string massage, Exception inner_exception) : base(massage, inner_exception) { }
    }
    public class DalCustomerNotExsist : Exception
    {
        public DalCustomerNotExsist() : base() { }
        public DalCustomerNotExsist(string massage) : base(massage) { }
        public DalCustomerNotExsist(string massage, Exception inner_exception) : base(massage, inner_exception) { }
    }


}
