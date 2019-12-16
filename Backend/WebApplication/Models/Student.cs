namespace T.Domain
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsDelete { get; set; }

        #region Reference

        //public ClassHistory ClassHistory { get; set; }

        #endregion
    }
}
