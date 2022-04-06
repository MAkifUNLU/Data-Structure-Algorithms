using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement
{
    //           TEK YÖNLÜ(SİNGLY) LİSTELER İÇİN NODE
    class NodeS<T>
    {
        public NodeS<T> next;
        public T _data;

        public NodeS(T data)
        {
            _data = data;
            next = null;
        }       
    }
    //           ÇİFT YÖNLÜ(DOUBLY) LİSTELER İÇİN NODE
    class NodeD<T>
    {
        public NodeD<T> next;
        public NodeD<T> prev;
        public T _data;

        public NodeD(T data)
        {
            _data = data;
            next = null;
        }
    }

}
