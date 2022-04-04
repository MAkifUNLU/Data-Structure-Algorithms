using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement
{
    //           ÇİFT YÖNLÜ(DOUBLY) LİSTELER İÇİN NODE
    class NodeL<T>
    {
        public NodeL<T> next;
        public T _data;

        public NodeL(T data)
        {
            _data = data;
            next = null;
        }
    }
    //           TEK YÖNLÜ(SİNGLY) LİSTELER İÇİN NODE
    class NodeC<T>
    {
        public NodeC<T> next;
        public NodeC<T> prev;
        public T _data;

        public NodeC(T data)
        {
            _data = data;
            next = null;
        }
    }

}
