using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Common
{
    public class GenericStack<T>
    {
        List<T> list = new List<T>();

        //Thêm phần tử vào đỉnh Stack
        public void Push(T item)
        {
            list.Add(item);
        }
        //Pop(): Lấy và xóa phần tử ở đỉnh stack.
        public T Pop()
        {
            T top = list[0]; // ^1 là phần tử cuối
            list.RemoveAt(0);
            return top;
        }
        //Peek(): Lấy phần tử ở đỉnh stack nhưng không xóa.
        public T Peek()
        {
            return list[0];
        }
        // Kiểm tra stack có rỗng không
        public bool IsEmpty()
        {
            return list.Count == 0;
        }
    }
}
