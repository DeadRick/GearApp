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

        List<TextBox> box = new() { ((MainWindow)Application.Current.MainWindow).infoC1P1,
                                    ((MainWindow)Application.Current.MainWindow).infoC1P2,
                                    ((MainWindow)Application.Current.MainWindow).infoC1Pk,
                                    ((MainWindow)Application.Current.MainWindow).infoC2P1,
                                    ((MainWindow)Application.Current.MainWindow).infoC2P2,
                                    ((MainWindow)Application.Current.MainWindow).infoC2Pk,
                                    ((MainWindow)Application.Current.MainWindow).infoC3P1,
                                    ((MainWindow)Application.Current.MainWindow).infoC3P2,
                                    ((MainWindow)Application.Current.MainWindow).infoC3Pk,
                                    ((MainWindow)Application.Current.MainWindow).infoC4P1,
                                    ((MainWindow)Application.Current.MainWindow).infoC4P2,
                                    ((MainWindow)Application.Current.MainWindow).infoC4Pk,
                                    ((MainWindow)Application.Current.MainWindow).infoC5P1,
                                    ((MainWindow)Application.Current.MainWindow).infoC5P2,
                                    ((MainWindow)Application.Current.MainWindow).infoC5Pk,
                                    ((MainWindow)Application.Current.MainWindow).infoC6P1,
                                    ((MainWindow)Application.Current.MainWindow).infoC6P2,
                                    ((MainWindow)Application.Current.MainWindow).infoC6Pk,
                                    ((MainWindow)Application.Current.MainWindow).infoC7P1,
                                    ((MainWindow)Application.Current.MainWindow).infoC7P2,
                                    ((MainWindow)Application.Current.MainWindow).infoC7Pk,
                                    ((MainWindow)Application.Current.MainWindow).infoC8P1,
                                    ((MainWindow)Application.Current.MainWindow).infoC8P2,
                                    ((MainWindow)Application.Current.MainWindow).infoC8Pk,
        };

        List<double> results;

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

            results = new() { dC1P1, dC1P2, dC1Pk,
                dC2P1,
                dC2P2,
                dC2Pk,

                dC3P1,
                dC3P2,
                dC3Pk,

                dC4P1,
                dC4P2,
                dC4Pk,

                dC5P1,
                dC5P2,
                dC5Pk,

                dC6P1,
                dC6P2,
                dC6Pk,

                dC7P1,
                dC7P2,
                dC7Pk,

                dC8P1,
                dC8P2,
                dC8Pk,
            };

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

        }

        public void GetAngleP1(double dRes, TextBox textBx)
        {
            dRes = AngleCoef(dRes);
            textBx.Text = dRes.ToString("f2");
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
                case 15:
                    return x * 0.9998;
                case 30:
                    return x * 0.998;
                case 40:
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
