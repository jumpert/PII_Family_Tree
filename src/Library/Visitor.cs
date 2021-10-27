using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public abstract class Visitor
    {
        public string Content
        {
            get
                {
                    return ContentAge.ToString();
                }
        }

        public int ContentAge;

        public abstract void Visit(Node node);

        //void Visit(Persona person);

    }
}