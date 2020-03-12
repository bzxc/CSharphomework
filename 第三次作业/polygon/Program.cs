using System;

namespace polygon
{
    class Program
    {
        interface polyg {
            double areaCul();
            bool isright();
        }

        class square: polyg {
            double x, y;

            public square(double X, double Y) {
                x = X;
                y = Y;
            }
            public double areaCul() {
                return x * y;
            }
            public bool isright(){
                return true;
            }
        }

        class triangle: polyg {
            double x, y, z;
            public triangle(double X, double Y, double Z) {
                x = X;
                y = Y;
                z = Z;
            }
            public double areaCul() {
                double p = (x + y + z) / 2;
                return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            }
            public bool isright() {
                if((x + y > z)&&(x + z > y)&&(y + z >x)) {
                    return true;
                }
                else return false;
            }
        }

        class rectangle: polyg {
            double x, y;
            public rectangle(double X, double Y) {
                x = X;
                y = Y;
            }
            public double areaCul() {
                return x * y;
            }
            public bool isright() {
                return true;
            }
        }

        class polygenFactory {
            public static polyg getPolygen(double x, double y, double z = 0) {
                polyg example = null;
                if(z==0) {
                    if(x==y) {
                        example = new square(x, y);
                    }
                    else example = new rectangle(x, y);
                }
                if(z!=0) {
                    example = new triangle(x, y, z);
                }
                return example;
            }
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            double countOfArea = 0;
            double xGroup;
            double yGroup;
            double zGroup;
            polyg test = null;
            int i = 0;
            while(i < 10) {
                xGroup = rnd.Next(1, 10);
                yGroup = rnd.Next(1, 10);
                if(rnd.Next(0, 2) == 0) {
                    zGroup = rnd.Next(1, 10);
                }
                else zGroup = 0;
                test = polygenFactory.getPolygen(xGroup, yGroup, zGroup);
                if(test.isright()) {
                    Console.WriteLine(test.areaCul());
                    countOfArea += test.areaCul();
                    i++;
                }
                
            }

            Console.WriteLine(countOfArea);
        }
    }
}
