using System;

namespace _08_Orange_Tree
{
    internal class OrangeTree
    {
        //Fields
        private bool treealive = true;
        private int age;
        private int height;
        private int numoranges = 0;
        private int orangeseaten = 0;

        //Constructor
        public OrangeTree(int age, int height)
        {
            this.age = age;
            this.height = height;
        }
        //Methods
        public void OneYearPasses()
        {
            if (age  < 79)
            {
                age++;
                height = height + 2;
                if (age >= 2)
                {
                    numoranges += 5;
                }
            }
            else
            {
                treealive = false;
            }
        }

        public void EatOrange(int eatenorange)
        {
            for (int i = 0; i < eatenorange; i++)
            {
                if (numoranges > 0)
                {
                    orangeseaten += 1;
                    numoranges -= 1;
                }
                else
                {
                    throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
                }
            }
                     
        }

        //Properties
        public int Age
        {
            get { return age; }
            //set { age = value; }
        }

        public int Height
        {
            get { return height; }
            //set { height = value; }
        }

        public bool TreeAlive
        {
            get { return treealive; }
            //set { treealive = value; }
        }

        public int NumOranges
        {
            get { return numoranges; }
            set { numoranges = value; }
        }
        public int OrangesEaten
        {
            get { return orangeseaten; }
            //set { orangeseaten = value; }
        }
    }

}