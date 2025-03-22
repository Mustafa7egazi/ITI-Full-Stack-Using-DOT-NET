namespace LabAssignmentDay07
{
    namespace EarlyBinding
    {
        class Parent
        {
            protected string parentName;
            public string Name { get { return parentName; } set { parentName = value; } }

            public Parent()
            {
                parentName = "Anonymous";
            }
            public Parent(string name)
            {
                this.parentName = name;
            }
            public string SayMyName()
            {
                return $"I'm [Parent]";
            }
        }


        class Child : Parent
        {
            protected string childName;
            public string ChildName { get { return childName; } set { childName = value; } }

            public Child()
            {
                childName = "Anonymous";
            }

            public Child(string name)
            {
                childName = name;
            }

            public new string SayMyName()
            {
                return $"I'm [Child]";
            }

        }

        class SubChild : Child
        {
            protected string subChildName;
            public string SubChildName { get { return subChildName; } set { subChildName = value; } }

            public SubChild()
            {
                subChildName = "Anonymous";
            }

            public SubChild(string name)
            {
                subChildName = name;
            }

            public new string SayMyName()
            {
                return $"I'm [Sub-Child] ";
            }
        }
    }
}
