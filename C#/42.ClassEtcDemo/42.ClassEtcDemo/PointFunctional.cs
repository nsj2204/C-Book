using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.ClassEtcDemo
{
    class Point2
    {
        public readonly int x;
        public readonly int y;
        
        public Point2(int x, int y)
        {
            this.x = x; // readonly 필드는 반드시 생성자로 초기화 필요
            this.y = y;
        }

        // [1] 생성자의 반환값을 나 자신(Point2)으로 지정
        public Point2 MoveBy(int dx, int dy)
        {
            return new Point2(x + dx, y + dy);
        }

    }

    class PointFunctional
    {
        static void Main(string[] args)
        {
            var point = new Point2(0, 0).MoveBy(100, 100).MoveBy(50, 50);
            System.Console.WriteLine($"X: {point.x}, Y: {point.y}");
        }
    }
}
