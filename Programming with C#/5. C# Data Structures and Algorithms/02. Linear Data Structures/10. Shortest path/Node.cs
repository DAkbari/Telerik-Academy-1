﻿namespace PathFinder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Node<T> where T : struct, IComparable<T>
    {
        private T value;
        private readonly List<Node<T>> childs;

        public Node(T value)
        {
            this.Value = value;
            this.childs = new List<Node<T>>();
        }

        public T Value
        {
            get { return this.value; }
            private set { this.value = value; }
        }

        public List<Node<T>> Childs
        {
            get { return this.childs.ToList(); }
        }

        public void AddChild(Node<T> child)
        {
            this.childs.Add(child);
        }
    }
}