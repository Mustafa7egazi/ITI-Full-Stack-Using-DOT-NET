
namespace LabAssignmentDay07
{
    namespace LateBinding
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
            public virtual string SayMyName()
            {
                return $"I'm parent with {parentName} name";
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

            public override string SayMyName()
            {
                return $"I'm child with name {childName} of {parentName}";
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

            public override string SayMyName()
            {
                return $"I'm child with name {subChildName} of {childName} of {parentName}";
            }
        }
    }
}
