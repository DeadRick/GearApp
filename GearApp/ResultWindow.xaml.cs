using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GearApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        private double dC1P1;
        private double dC1P2;
        private double dC1Pk;

        private double dC2P1;
        private double dC2P2;
        private double dC2Pk;

        private double dC3P1;
        private double dC3P2;
        private double dC3Pk;

        private double dC4P1;
        private double dC4P2;
        private double dC4Pk;

        private double dC5P1;
        private double dC5P2;
        private double dC5Pk;

        private double dC6P1;
        private double dC6P2;
        private double dC6Pk;

        private double dC7P1;
        private double dC7P2;
        private double dC7Pk;

        private double dC8P1;
        private double dC8P2;
        private double dC8Pk;

        private double weightSea;
        private double tempEngine;
        private double speedEngine;
        private int angleRes;




        public ResultWindow()
        {
            InitializeComponent();
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC1P1.Text, out dC1P1);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC1P2.Text, out dC1P2);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC1Pk.Text, out dC1Pk);

            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC2P1.Text, out dC2P1);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC2P2.Text, out dC2P2);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC2Pk.Text, out dC2Pk);

            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC3P1.Text, out dC3P1);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC3P2.Text, out dC3P2);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC3Pk.Text, out dC3Pk);

            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC4P1.Text, out dC4P1);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC4P2.Text, out dC4P2);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC4Pk.Text, out dC4Pk);

            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC5P1.Text, out dC5P1);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC5P2.Text, out dC5P2);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC5Pk.Text, out dC5Pk);

            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC6P1.Text, out dC6P1);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC6P2.Text, out dC6P2);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC6Pk.Text, out dC6Pk);

            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC7P1.Text, out dC7P1);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC7P2.Text, out dC7P2);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC7Pk.Text, out dC7Pk);

            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC8P1.Text, out dC8P1);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC8P2.Text, out dC8P2);
            double.TryParse(((MainWindow)Application.Current.MainWindow).infoC8Pk.Text, out dC8Pk);

            double.TryParse(((MainWindow)Application.Current.MainWindow).heightSea.Text, out weightSea);
            double.TryParse(((MainWindow)Application.Current.MainWindow).engineTemp.Text, out tempEngine);
            double.TryParse(((MainWindow)Application.Current.MainWindow).engineSpeed.Text, out speedEngine);

            int.TryParse(((MainWindow)Application.Current.MainWindow).angle.Text, out angleRes);

   

            GetSeaP1();
            GetSeaP2();
            GetSeaPk();

            GetTempP1();
            GetTempP2();
            GetTempPk();

            GetSpeedP1();
            GetSpeedP2();
            GetSpeedPk();

            GetAngleP1();
            GetAngleP2();
            GetAnglePk();


            GetSeaP1C2();
            GetSeaP2C2();
            GetSeaPkC2();

            GetTempP1C2();
            GetTempP2C2();
            GetTempPkC2();

            GetSpeedP1C2();
            GetSpeedP2C2();
            GetSpeedPkC2();

            GetAngleP1C2();
            GetAngleP2C2();
            GetAnglePkC2();

            GetSeaP1C3();
            GetSeaP2C3();
            GetSeaPkC3();

            GetTempP1C2();
            GetTempP2C2();
            GetTempPkC2();

            GetSpeedP1C3();
            GetSpeedP2C3();
            GetSpeedPkC3();

            GetAngleP1C3();
            GetAngleP2C3();
            GetAnglePkC3();

            GetSeaP1C4();
            GetSeaP2C4();
            GetSeaPkC4();

            GetTempP1C4();
            GetTempP2C4();
            GetTempPkC4();

            GetSpeedP1C4();
            GetSpeedP2C4();
            GetSpeedPkC4();

            GetAngleP1C4();
            GetAngleP2C4();
            GetAnglePkC4();

            GetSeaP1C5();
            GetSeaP2C5();
            GetSeaPkC5();

            GetTempP1C5();
            GetTempP2C5();
            GetTempPkC5();

            GetSpeedP1C5();
            GetSpeedP2C5();
            GetSpeedPkC5();

            GetAngleP1C5();
            GetAngleP2C5();
            GetAnglePkC5();

            GetSeaP1C6();
            GetSeaP2C6();
            GetSeaPkC6();

            GetTempP1C6();
            GetTempP2C6();
            GetTempPkC6();

            GetSpeedP1C6();
            GetSpeedP2C6();
            GetSpeedPkC6();

            GetAngleP1C6();
            GetAngleP2C6();
            GetAnglePkC6();

            GetSeaP1C7();
            GetSeaP2C7();
            GetSeaPkC7();

            GetTempP1C7();
            GetTempP2C7();
            GetTempPkC7();

            GetSpeedP1C7();
            GetSpeedP2C7();
            GetSpeedPkC7();

            GetAngleP1C7();
            GetAngleP2C7();
            GetAnglePkC7();

            GetSeaP1C8();
            GetSeaP2C8();
            GetSeaPkC8();

            GetTempP1C8();
            GetTempP2C8();
            GetTempPkC8();

            GetSpeedP1C8();
            GetSpeedP2C8();
            GetSpeedPkC8();

            GetAngleP1C8();
            GetAngleP2C8();
            GetAnglePkC8();

            C1.Text = Comments(dC1P1, dC1P2);
            C2.Text = Comments(dC2P1, dC2P2);
            C3.Text = Comments(dC3P1, dC3P2);
            C4.Text = Comments(dC4P1, dC4P2);
            C5.Text = Comments(dC5P1, dC5P2);
            C6.Text = Comments(dC6P1, dC6P2);
            C7.Text = Comments(dC7P1, dC7P2);
            C8.Text = Comments(dC8P1, dC8P2);


        }

        public string Comments(double p1, double p2)
        {
            if (0.9 <= p1 && p1 <= 0.94 && 0.14 <= p2 && p2 <= 0.17)
            {
                return "0 – номинальное состояние ЦПГ";
            }
            if (0.8 <= p1 && p1 <= 0.94)
            {
                if (0.2 <= p2 && p2 <= 0.3)
                {
                    return "1 – состояние текущего износа";
                }
                else if (0.26 <= p2 && p2 <= 0.3)
                {
                    return "2 – предельный износ компрессионных колец";
                }
                else if (0 <= p2 && p2 <= 0.12)
                {
                    return "3 – закоксовка, поломка маслосъемных колец";
                }
                else if (0.3 <= p2 && p2 <= 0.45)
                {
                    return "4 – износ поршневых канавок; 5 – закоксовка компрессионных колец;";
                }
                else if (0.5 <= p2 && p2 <= 0.7)
                {
                    return "6 – поломка компрессионных колец";
                }

            }
            if (0.72 <= p1 && p1 <= 0.8)
            {
                if (0.1 <= p2 && p2 <= 0.25)
                {
                    return "7 – сильный износ (коробление) гильзы цилиндра";
                } else if (0.3 <= p2 && p2 < 0.45)
                {
                    return "8 – износ гильз с закоксовкой поршневых колец";
                } else if (0.1 <= p2 && p2 <= 0.2)
                {
                    return "9 – нарушение фазы выпускного клапана в сторону опережения открытия";
                }
            }
            if (0.4 < p1 && p1 < 0.65)
            {
                if (0.35 <= p2 && p2 <= 0.6)
                {
                    return "10 – нарушение герметичности сопряжения «клапан-седло» из-за механических повреждений, либо отсутствие теплового зазора";
                } else if (0 <= p2 && p2 <= 0.1)
                {
                    return "9 – нарушение фазы выпускного клапана в сторону опережения открытия";
                }
            }
            if (0 <= p1 && p1 <= 0.3)
            {
                if (0.3 >= p2 && p2 >= 0)
                {
                    return "11 – прогар поршня";
                } else if (p2 == 0)
                {
                    return "12 – поломка клапанных пружин впускных или выпускных клапанов";
                }
            }
            return "";
        }
        // C8
        public void GetAngleP1C8()
        {
            dC8P1 = AngleCoefC8(dC8P1);
            resC8P1.Text = dC8P1.ToString("f2");

        }

        public void GetAngleP2C8()
        {
            dC8P2 = AngleCoefC8(dC8P2);
            resC8P2.Text = dC8P2.ToString("f2");
        }
        public void GetAnglePkC8()
        {
            dC8Pk = AngleCoefC8(dC8Pk);
            resC8Pk.Text = dC8Pk.ToString("f2");
        }

        public double AngleCoefC8(double x)
        {
            switch (angleRes)
            {
                case 0:
                    return x * 1;
                case 30:
                    return x * 0.9998;
                case 60:
                    return x * 0.998;
                case 90:
                    return x * 0.99;
                default:
                    return x;
            }
        }

        // Third

        public void GetSpeedP1C8()
        {
            double coef = SpeedCoefC8(0.000146666, 0.86746666);
            dC8P1 = dC8P1 * coef;
            resC8P1.Text = dC8P1.ToString("f2");
        }
        public void GetSpeedP2C8()
        {
            double coef = SpeedCoefC82(-0.0008, 0.366);
            dC8P2 = dC8P2 * coef;
            resC8P2.Text = dC8P2.ToString("f2");
        }
        public void GetSpeedPkC8()
        {
            double coef = SpeedCoefC82(0.01826666, 25.1146666);
            dC8Pk = dC8Pk * coef;
            resC8Pk.Text = (dC8Pk).ToString("f2");
        }

        public double SpeedCoefC8(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return constY / y;
        }
        public double SpeedCoefC82(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return y / constY;
        }

        // Second

        public void GetTempP1C8()
        {
            double coef = TempCoefC8(0.000125, 0.9035);
            dC8P1 = dC8P1 * coef;
            resC8P1.Text = dC8P1.ToString("f2");
        }
        public void GetTempP2C8()
        {
            double coef = TempCoefC8(-0.0034, 0.47);
            dC8P2 = dC8P2 * coef;
            resC8P2.Text = dC8P2.ToString("f2");
        }
        public void GetTempPkC8()
        {

            double y = 0.391 * tempEngine + 8.3999;
            double constY = 0.391 * 60 + 8.3999;
            double coef = constY / y;

            dC8Pk = dC8Pk * coef;
            resC8Pk.Text = (dC8Pk).ToString("f2");
        }

        public double TempCoefC8(double x1, double x2)
        {
            double y = x1 * tempEngine + x2;
            double constY = x1 * 60 + x2;
            return y / constY;
        }
        // First
        public void GetSeaP1C8()
        {
            double coef = SolveCoeffC8(-0.0000851063829787233, 0.862765957446808);
            dC8P1 = dC8P1 * coef;
            resC8P1.Text = dC8P1.ToString("f2");
        }
        public void GetSeaP2C8()
        {
            double coef = SolveCoeffC8(-0.0000297872340425531, 0.314468085106382);
            dC8P2 = dC8P2 * coef;
            resC8P2.Text = dC8P2.ToString("f2");
        }

        public void GetSeaPkC8()
        {
            double coef = SolveCoeffC8(-0.00114893617021276, 12.2723404255319);
            dC8Pk = dC8Pk * coef;
            resC8Pk.Text = ((int)dC8Pk).ToString("f2");
        }

        public double SolveCoeffC8(double x1, double x2)
        {
            double y = x1 * weightSea + x2;
            double constY = x1 * 150 + x2;
            return constY / y;
        }
        // ----

        // C7
        public void GetAngleP1C7()
        {
            dC7P1 = AngleCoefC7(dC7P1);
            resC7P1.Text = dC7P1.ToString("f2");

        }

        public void GetAngleP2C7()
        {
            dC7P2 = AngleCoefC7(dC7P2);
            resC7P2.Text = dC7P2.ToString("f2");
        }
        public void GetAnglePkC7()
        {
            dC7Pk = AngleCoefC7(dC7Pk);
            resC7Pk.Text = dC7Pk.ToString("f2");
        }

        public double AngleCoefC7(double x)
        {
            switch (angleRes)
            {
                case 0:
                    return x * 1;
                case 30:
                    return x * 0.9998;
                case 60:
                    return x * 0.998;
                case 90:
                    return x * 0.99;
                default:
                    return x;
            }
        }

        // Third

        public void GetSpeedP1C7()
        {
            double coef = SpeedCoefC7(0.000146666, 0.86746666);
            dC7P1 = dC7P1 * coef;
            resC7P1.Text = dC7P1.ToString("f2");
        }
        public void GetSpeedP2C7()
        {
            double coef = SpeedCoefC72(-0.0008, 0.366);
            dC7P2 = dC7P2 * coef;
            resC7P2.Text = dC7P2.ToString("f2");
        }
        public void GetSpeedPkC7()
        {
            double coef = SpeedCoefC72(0.01826666, 25.1146666);
            dC7Pk = dC7Pk * coef;
            resC7Pk.Text = (dC7Pk).ToString("f2");
        }

        public double SpeedCoefC7(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return constY / y;
        }
        public double SpeedCoefC72(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return y / constY;
        }

        // Second

        public void GetTempP1C7()
        {
            double coef = TempCoefC7(0.000125, 0.9035);
            dC7P1 = dC7P1 * coef;
            resC7P1.Text = dC7P1.ToString("f2");
        }
        public void GetTempP2C7()
        {
            double coef = TempCoefC7(-0.0034, 0.47);
            dC7P2 = dC7P2 * coef;
            resC7P2.Text = dC7P2.ToString("f2");
        }
        public void GetTempPkC7()
        {

            double y = 0.391 * tempEngine + 8.3999;
            double constY = 0.391 * 60 + 8.3999;
            double coef = constY / y;

            dC7Pk = dC7Pk * coef;
            resC7Pk.Text = (dC7Pk).ToString("f2");
        }

        public double TempCoefC7(double x1, double x2)
        {
            double y = x1 * tempEngine + x2;
            double constY = x1 * 60 + x2;
            return y / constY;
        }
        // First
        public void GetSeaP1C7()
        {
            double coef = SolveCoeffC7(-0.0000851063829787233, 0.862765957446808);
            dC7P1 = dC7P1 * coef;
            resC7P1.Text = dC7P1.ToString("f2");
        }
        public void GetSeaP2C7()
        {
            double coef = SolveCoeffC7(-0.0000297872340425531, 0.314468085106382);
            dC7P2 = dC7P2 * coef;
            resC7P2.Text = dC7P2.ToString("f2");
        }

        public void GetSeaPkC7()
        {
            double coef = SolveCoeffC7(-0.00114893617021276, 12.2723404255319);
            dC7Pk = dC7Pk * coef;
            resC7Pk.Text = ((int)dC7Pk).ToString("f2");
        }

        public double SolveCoeffC7(double x1, double x2)
        {
            double y = x1 * weightSea + x2;
            double constY = x1 * 150 + x2;
            return constY / y;
        }
        // ----

        // C6
        public void GetAngleP1C6()
        {
            dC6P1 = AngleCoefC6(dC6P1);
            resC6P1.Text = dC6P1.ToString("f2");

        }

        public void GetAngleP2C6()
        {
            dC6P2 = AngleCoefC6(dC6P2);
            resC6P2.Text = dC6P2.ToString("f2");
        }
        public void GetAnglePkC6()
        {
            dC6Pk = AngleCoefC6(dC6Pk);
            resC6Pk.Text = dC6Pk.ToString("f2");
        }

        public double AngleCoefC6(double x)
        {
            switch (angleRes)
            {
                case 0:
                    return x * 1;
                case 30:
                    return x * 0.9998;
                case 60:
                    return x * 0.998;
                case 90:
                    return x * 0.99;
                default:
                    return x;
            }
        }

        // Third

        public void GetSpeedP1C6()
        {
            double coef = SpeedCoefC6(0.000146666, 0.86746666);
            dC6P1 = dC6P1 * coef;
            resC6P1.Text = dC6P1.ToString("f2");
        }
        public void GetSpeedP2C6()
        {
            double coef = SpeedCoefC62(-0.0008, 0.366);
            dC6P2 = dC6P2 * coef;
            resC6P2.Text = dC6P2.ToString("f2");
        }
        public void GetSpeedPkC6()
        {
            double coef = SpeedCoefC62(0.01826666, 25.1146666);
            dC6Pk = dC6Pk * coef;
            resC6Pk.Text = (dC6Pk).ToString("f2");
        }

        public double SpeedCoefC6(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return constY / y;
        }
        public double SpeedCoefC62(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return y / constY;
        }

        // Second

        public void GetTempP1C6()
        {
            double coef = TempCoefC6(0.000125, 0.9035);
            dC6P1 = dC6P1 * coef;
            resC6P1.Text = dC6P1.ToString("f2");
        }
        public void GetTempP2C6()
        {
            double coef = TempCoefC6(-0.0034, 0.47);
            dC6P2 = dC6P2 * coef;
            resC6P2.Text = dC6P2.ToString("f2");
        }
        public void GetTempPkC6()
        {

            double y = 0.391 * tempEngine + 8.3999;
            double constY = 0.391 * 60 + 8.3999;
            double coef = constY / y;

            dC6Pk = dC6Pk * coef;
            resC6Pk.Text = (dC6Pk).ToString("f2");
        }

        public double TempCoefC6(double x1, double x2)
        {
            double y = x1 * tempEngine + x2;
            double constY = x1 * 60 + x2;
            return y / constY;
        }
        // First
        public void GetSeaP1C6()
        {
            double coef = SolveCoeffC6(-0.0000851063829787233, 0.862765957446808);
            dC6P1 = dC6P1 * coef;
            resC6P1.Text = dC6P1.ToString("f2");
        }
        public void GetSeaP2C6()
        {
            double coef = SolveCoeffC6(-0.0000297872340425531, 0.314468085106382);
            dC6P2 = dC6P2 * coef;
            resC6P2.Text = dC6P2.ToString("f2");
        }

        public void GetSeaPkC6()
        {
            double coef = SolveCoeffC6(-0.00114893617021276, 12.2723404255319);
            dC6Pk = dC6Pk * coef;
            resC6Pk.Text = ((int)dC6Pk).ToString("f2");
        }

        public double SolveCoeffC6(double x1, double x2)
        {
            double y = x1 * weightSea + x2;
            double constY = x1 * 150 + x2;
            return constY / y;
        }
        // ----

        // C5
        public void GetAngleP1C5()
        {
            dC5P1 = AngleCoefC5(dC5P1);
            resC5P1.Text = dC5P1.ToString("f2");

        }

        public void GetAngleP2C5()
        {
            dC5P2 = AngleCoefC5(dC5P2);
            resC5P2.Text = dC5P2.ToString("f2");
        }
        public void GetAnglePkC5()
        {
            dC5Pk = AngleCoefC5(dC5Pk);
            resC5Pk.Text = dC5Pk.ToString("f2");
        }

        public double AngleCoefC5(double x)
        {
            switch (angleRes)
            {
                case 0:
                    return x * 1;
                case 30:
                    return x * 0.9998;
                case 60:
                    return x * 0.998;
                case 90:
                    return x * 0.99;
                default:
                    return x;
            }
        }

        // Third

        public void GetSpeedP1C5()
        {
            double coef = SpeedCoefC5(0.000146666, 0.86746666);
            dC5P1 = dC5P1 * coef;
            resC5P1.Text = dC5P1.ToString("f2");
        }
        public void GetSpeedP2C5()
        {
            double coef = SpeedCoefC52(-0.0008, 0.366);
            dC5P2 = dC5P2 * coef;
            resC5P2.Text = dC5P2.ToString("f2");
        }
        public void GetSpeedPkC5()
        {
            double coef = SpeedCoefC52(0.01826666, 25.1146666);
            dC5Pk = dC5Pk * coef;
            resC5Pk.Text = (dC5Pk).ToString("f2");
        }

        public double SpeedCoefC5(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return constY / y;
        }
        public double SpeedCoefC52(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return y / constY;
        }

        // Second

        public void GetTempP1C5()
        {
            double coef = TempCoefC5(0.000125, 0.9035);
            dC5P1 = dC5P1 * coef;
            resC5P1.Text = dC5P1.ToString("f2");
        }
        public void GetTempP2C5()
        {
            double coef = TempCoefC5(-0.0034, 0.47);
            dC5P2 = dC5P2 * coef;
            resC5P2.Text = dC5P2.ToString("f2");
        }
        public void GetTempPkC5()
        {

            double y = 0.391 * tempEngine + 8.3999;
            double constY = 0.391 * 60 + 8.3999;
            double coef = constY / y;

            dC5Pk = dC5Pk * coef;
            resC5Pk.Text = (dC5Pk).ToString("f2");
        }

        public double TempCoefC5(double x1, double x2)
        {
            double y = x1 * tempEngine + x2;
            double constY = x1 * 60 + x2;
            return y / constY;
        }
        // First
        public void GetSeaP1C5()
        {
            double coef = SolveCoeffC5(-0.0000851063829787233, 0.862765957446808);
            dC5P1 = dC5P1 * coef;
            resC5P1.Text = dC5P1.ToString("f2");
        }
        public void GetSeaP2C5()
        {
            double coef = SolveCoeffC5(-0.0000297872340425531, 0.314468085106382);
            dC5P2 = dC5P2 * coef;
            resC5P2.Text = dC5P2.ToString("f2");
        }

        public void GetSeaPkC5()
        {
            double coef = SolveCoeffC5(-0.00114893617021276, 12.2723404255319);
            dC5Pk = dC5Pk * coef;
            resC5Pk.Text = ((int)dC5Pk).ToString("f2");
        }

        public double SolveCoeffC5(double x1, double x2)
        {
            double y = x1 * weightSea + x2;
            double constY = x1 * 150 + x2;
            return constY / y;
        }
        // ----

        // C4
        public void GetAngleP1C4()
        {
            dC4P1 = AngleCoefC4(dC4P1);
            resC4P1.Text = dC4P1.ToString("f2");

        }

        public void GetAngleP2C4()
        {
            dC4P2 = AngleCoefC4(dC4P2);
            resC4P2.Text = dC4P2.ToString("f2");
        }
        public void GetAnglePkC4()
        {
            dC4Pk = AngleCoefC4(dC4Pk);
            resC4Pk.Text = dC4Pk.ToString("f2");
        }

        public double AngleCoefC4(double x)
        {
            switch (angleRes)
            {
                case 0:
                    return x * 1;
                case 30:
                    return x * 0.9998;
                case 60:
                    return x * 0.998;
                case 90:
                    return x * 0.99;
                default:
                    return x;
            }
        }

        // Third

        public void GetSpeedP1C4()
        {
            double coef = SpeedCoefC4(0.000146666, 0.86746666);
            dC4P1 = dC4P1 * coef;
            resC4P1.Text = dC4P1.ToString("f2");
        }
        public void GetSpeedP2C4()
        {
            double coef = SpeedCoefC42(-0.0008, 0.366);
            dC4P2 = dC4P2 * coef;
            resC4P2.Text = dC4P2.ToString("f2");
        }
        public void GetSpeedPkC4()
        {
            double coef = SpeedCoefC42(0.01826666, 25.1146666);
            dC4Pk = dC4Pk * coef;
            resC4Pk.Text = (dC4Pk).ToString("f2");
        }

        public double SpeedCoefC4(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return constY / y;
        }
        public double SpeedCoefC42(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return y / constY;
        }

        // Second

        public void GetTempP1C4()
        {
            double coef = TempCoefC4(0.000125, 0.9035);
            dC4P1 = dC4P1 * coef;
            resC4P1.Text = dC4P1.ToString("f2");
        }
        public void GetTempP2C4()
        {
            double coef = TempCoefC4(-0.0034, 0.47);
            dC4P2 = dC4P2 * coef;
            resC4P2.Text = dC4P2.ToString("f2");
        }
        public void GetTempPkC4()
        {

            double y = 0.391 * tempEngine + 8.3999;
            double constY = 0.391 * 60 + 8.3999;
            double coef = constY / y;

            dC4Pk = dC4Pk * coef;
            resC4Pk.Text = (dC4Pk).ToString("f2");
        }

        public double TempCoefC4(double x1, double x2)
        {
            double y = x1 * tempEngine + x2;
            double constY = x1 * 60 + x2;
            return y / constY;
        }
        // First
        public void GetSeaP1C4()
        {
            double coef = SolveCoeffC4(-0.0000851063829787233, 0.862765957446808);
            dC4P1 = dC4P1 * coef;
            resC4P1.Text = dC4P1.ToString("f2");
        }
        public void GetSeaP2C4()
        {
            double coef = SolveCoeffC4(-0.0000297872340425531, 0.314468085106382);
            dC4P2 = dC4P2 * coef;
            resC4P2.Text = dC4P2.ToString("f2");
        }

        public void GetSeaPkC4()
        {
            double coef = SolveCoeffC4(-0.00114893617021276, 12.2723404255319);
            dC4Pk = dC4Pk * coef;
            resC4Pk.Text = ((int)dC4Pk).ToString("f2");
        }

        public double SolveCoeffC4(double x1, double x2)
        {
            double y = x1 * weightSea + x2;
            double constY = x1 * 150 + x2;
            return constY / y;
        }
        // ----

        // C3
        public void GetAngleP1C3()
        {
            dC3P1 = AngleCoefC3(dC3P1);
            resC3P1.Text = dC3P1.ToString("f2");

        }

        public void GetAngleP2C3()
        {
            dC3P2 = AngleCoefC3(dC3P2);
            resC3P2.Text = dC3P2.ToString("f2");
        }
        public void GetAnglePkC3()
        {
            dC3Pk = AngleCoefC3(dC3Pk);
            resC3Pk.Text = dC3Pk.ToString("f2");
        }

        public double AngleCoefC3(double x)
        {
            switch (angleRes)
            {
                case 0:
                    return x * 1;
                case 30:
                    return x * 0.9998;
                case 60:
                    return x * 0.998;
                case 90:
                    return x * 0.99;
                default:
                    return x;
            }
        }

        // Third

        public void GetSpeedP1C3()
        {
            double coef = SpeedCoefC3(0.000146666, 0.86746666);
            dC3P1 = dC3P1 * coef;
            resC3P1.Text = dC3P1.ToString("f2");
        }
        public void GetSpeedP2C3()
        {
            double coef = SpeedCoefC32(-0.0008, 0.366);
            dC3P2 = dC3P2 * coef;
            resC3P2.Text = dC3P2.ToString("f2");
        }
        public void GetSpeedPkC3()
        {
            double coef = SpeedCoefC32(0.01826666, 25.1146666);
            dC3Pk = dC3Pk * coef;
            resC3Pk.Text = (dC3Pk).ToString("f2");
        }

        public double SpeedCoefC3(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return constY / y;
        }
        public double SpeedCoefC32(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return y / constY;
        }

        // Second

        public void GetTempP1C3()
        {
            double coef = TempCoefC3(0.000125, 0.9035);
            dC3P1 = dC3P1 * coef;
            resC3P1.Text = dC3P1.ToString("f2");
        }
        public void GetTempP2C3()
        {
            double coef = TempCoefC3(-0.0034, 0.47);
            dC3P2 = dC3P2 * coef;
            resC3P2.Text = dC3P2.ToString("f2");
        }
        public void GetTempPkC3()
        {

            double y = 0.391 * tempEngine + 8.3999;
            double constY = 0.391 * 60 + 8.3999;
            double coef = constY / y;

            dC3Pk = dC3Pk * coef;
            resC3Pk.Text = (dC3Pk).ToString("f2");
        }

        public double TempCoefC3(double x1, double x2)
        {
            double y = x1 * tempEngine + x2;
            double constY = x1 * 60 + x2;
            return y / constY;
        }
        // First
        public void GetSeaP1C3()
        {
            double coef = SolveCoeffC3(-0.0000851063829787233, 0.862765957446808);
            dC3P1 = dC3P1 * coef;
            resC3P1.Text = dC3P1.ToString("f2");
        }
        public void GetSeaP2C3()
        {
            double coef = SolveCoeffC3(-0.0000297872340425531, 0.314468085106382);
            dC3P2 = dC3P2 * coef;
            resC3P2.Text = dC3P2.ToString("f2");
        }

        public void GetSeaPkC3()
        {
            double coef = SolveCoeffC3(-0.00114893617021276, 12.2723404255319);
            dC3Pk = dC3Pk * coef;
            resC3Pk.Text = ((int)dC3Pk).ToString("f2");
        }

        public double SolveCoeffC3(double x1, double x2)
        {
            double y = x1 * weightSea + x2;
            double constY = x1 * 150 + x2;
            return constY / y;
        }
        // ----

        // C2
        public void GetAngleP1C2()
        {
            dC2P1 = AngleCoefC2(dC2P1);
            resC2P1.Text = dC2P1.ToString("f2");

        }

        public void GetAngleP2C2()
        {
            dC2P2 = AngleCoefC2(dC2P2);
            resC2P2.Text = dC2P2.ToString("f2");
        }
        public void GetAnglePkC2()
        {
            dC2Pk = AngleCoefC2(dC2Pk);
            resC2Pk.Text = dC2Pk.ToString("f2");
        }

        public double AngleCoefC2(double x)
        {
            switch (angleRes)
            {
                case 0:
                    return x * 1;
                case 30:
                    return x * 0.9998;
                case 60:
                    return x * 0.998;
                case 90:
                    return x * 0.99;
                default:
                    return x;
            }
        }

        // Third

        public void GetSpeedP1C2()
        {
            double coef = SpeedCoefC2(0.000146666, 0.86746666);
            dC2P1 = dC2P1 * coef;
            resC2P1.Text = dC2P1.ToString("f2");
        }
        public void GetSpeedP2C2()
        {
            double coef = SpeedCoefC22(-0.0008, 0.366);
            dC2P2 = dC2P2 * coef;
            resC2P2.Text = dC2P2.ToString("f2");
        }
        public void GetSpeedPkC2()
        {
            double coef = SpeedCoefC22(0.01826666, 25.1146666);
            dC2Pk = dC2Pk * coef;
            resC2Pk.Text = (dC2Pk).ToString("f2");
        }

        public double SpeedCoefC2(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return constY / y;
        }
        public double SpeedCoefC22(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return y / constY;
        }

        // Second

        public void GetTempP1C2()
        {
            double coef = TempCoefC2(0.000125, 0.9035);
            dC2P1 = dC2P1 * coef;
            resC2P1.Text = dC2P1.ToString("f2");
        }
        public void GetTempP2C2()
        {
            double coef = TempCoefC2(-0.0034, 0.47);
            dC2P2 = dC2P2 * coef;
            resC2P2.Text = dC2P2.ToString("f2");
        }
        public void GetTempPkC2()
        {

            double y = 0.391 * tempEngine + 8.3999;
            double constY = 0.391 * 60 + 8.3999;
            double coef = constY / y;

            dC2Pk = dC2Pk * coef;
            resC2Pk.Text = (dC2Pk).ToString("f2");
        }

        public double TempCoefC2(double x1, double x2)
        {
            double y = x1 * tempEngine + x2;
            double constY = x1 * 60 + x2;
            return y / constY;
        }
        // First
        public void GetSeaP1C2()
        {
            double coef = SolveCoeffC2(-0.0000851063829787233, 0.862765957446808);
            dC2P1 = dC2P1 * coef;
            resC2P1.Text = dC2P1.ToString("f2");
        }
        public void GetSeaP2C2()
        {
            double coef = SolveCoeffC2(-0.0000297872340425531, 0.314468085106382);
            dC2P2 = dC2P2 * coef;
            resC2P2.Text = dC2P2.ToString("f2");
        }

        public void GetSeaPkC2()
        {
            double coef = SolveCoeffC2(-0.00114893617021276, 12.2723404255319);
            dC2Pk = dC2Pk * coef;
            resC2Pk.Text = ((int)dC2Pk).ToString("f2");
        }

        public double SolveCoeffC2(double x1, double x2)
        {
            double y = x1 * weightSea + x2;
            double constY = x1 * 150 + x2;
            return constY / y;
        }
        // ----


        // C1
        public void GetAngleP1()
        {
            dC1P1 = AngleCoef(dC1P1);
            resC1P1.Text = dC1P1.ToString("f2");

        }

        public void GetAngleP2()
        {
            dC1P2 = AngleCoef(dC1P2);
            resC1P2.Text = dC1P2.ToString("f2");
        }
        public void GetAnglePk()
        {
            dC1Pk = AngleCoef(dC1Pk);
            resC1Pk.Text = dC1Pk.ToString("f2");
        }

        public double AngleCoef(double x)
        {
            switch (angleRes)
            {
                case 0:
                    return x * 1;
                case 30:
                    return x * 0.9998;
                case 60:
                    return x * 0.998;
                case 90:
                    return x * 0.99;
                default:
                    return x;
            }
        }

        // Third

        public void GetSpeedP1()
        {
            double coef = SpeedCoef(0.000146666, 0.86746666);
            dC1P1 = dC1P1 * coef;
            resC1P1.Text = dC1P1.ToString("f2");
        }
        public void GetSpeedP2()
        {
            double coef = SpeedCoef2(-0.0008, 0.366);
            dC1P2 = dC1P2 * coef;
            resC1P2.Text = dC1P2.ToString("f2");
        }
        public void GetSpeedPk()
        {
            double coef = SpeedCoef2(0.01826666, 25.1146666);
            dC1Pk = dC1Pk * coef;
            resC1Pk.Text = (dC1Pk).ToString("f2");
        }

        public double SpeedCoef(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return constY / y;
        }
        public double SpeedCoef2(double x1, double x2)
        {
            double y = x1 * speedEngine + x2;
            double constY = x1 * 170 + x2;
            return y / constY;
        }

        // Second

        public void GetTempP1()
        {
            double coef = TempCoef(0.000125, 0.9035);
            dC1P1 = dC1P1 * coef;
            resC1P1.Text = dC1P1.ToString("f2");
        }
        public void GetTempP2()
        {
            double coef = TempCoef(-0.0034, 0.47);
            dC1P2 = dC1P2 * coef;
            resC1P2.Text = dC1P2.ToString("f2");
        }
        public void GetTempPk()
        {

            double y = 0.391 * tempEngine + 8.3999;
            double constY = 0.391 * 60 + 8.3999;
            double coef = constY / y;

            dC1Pk = dC1Pk * coef;
            resC1Pk.Text = (dC1Pk).ToString("f2");
        }

        public double TempCoef(double x1, double x2)
        {
            double y = x1 * tempEngine + x2;
            double constY = x1 * 60 + x2;
            return y / constY;
        }
        // First
        public void GetSeaP1()
        {
            double coef = SolveCoeff(-0.0000851063829787233, 0.862765957446808);
            dC1P1 = dC1P1 * coef;
            resC1P1.Text = dC1P1.ToString("f2");
        }
        public void GetSeaP2()
        {
            double coef = SolveCoeff(-0.0000297872340425531, 0.314468085106382);
            dC1P2 = dC1P2 * coef;
            resC1P2.Text = dC1P2.ToString("f2");
        }

        public void GetSeaPk()
        {
            double coef = SolveCoeff(-0.00114893617021276, 12.2723404255319);
            dC1Pk = dC1Pk * coef;
            resC1Pk.Text = ((int)dC1Pk).ToString("f2");
        }

        public double SolveCoeff(double x1, double x2)
        {
            double y = x1 * weightSea + x2;
            double constY = x1 * 150 + x2;
            return constY / y;
        }
        // ----

    }
}
