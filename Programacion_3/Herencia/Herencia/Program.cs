/*
 * Crear una jerarquía de clases utilizando herencia
 * Considere una cuenta bancaria, la que puede ser de dos tipo C.Ahorro y C.Corriente
 * Una CC puede tener un tope de descubierto, y en tal caso posee intereses negativos
 * Simule 100 iteraciones (depósito/extraccion) ingresando montos aleatorios que pueden
 * ir de $10 a $10000
 */
namespace Herencia
{
    public class CuentaBancaria
    {
        protected double saldo;

        public CuentaBancaria(double saldoInicial)
        {
            this.saldo = saldoInicial;
        }

        public void Depositar(double monto)
        {
            this.saldo += monto;
        }

        public virtual void Extraer(double monto)
        {
            this.saldo -= monto;
        }

        public double ObtenerSaldo()
        {
            return this.saldo;
        }
    }

    public class CuentaAhorro : CuentaBancaria
    {
        private double tasaInteres;

        public CuentaAhorro(double saldoInicial,double tasaInteres) : base(saldoInicial)
        {
            this.tasaInteres = tasaInteres;
        }

        public override void Extraer(double monto)
        {
            if (monto > saldo)
            {
                Console.WriteLine("No puede extraer más dinero del que hay en la cuenta");
            }
            else
            {
                saldo -= monto;
            }
        }

        public void CalcularIntereses()
        {
            double intereses = saldo * tasaInteres / 100;
            saldo += intereses;
        }
    }

    class CuentaCorriente : CuentaBancaria
    {
        private double topeDescubierto;
        private double interesesDescubierto;

        public CuentaCorriente(double saldoInicial, double topeDescubierto, double interesesDescubierto) : base(topeDescubierto)
        {
            this.topeDescubierto = topeDescubierto;
            this.interesesDescubierto = interesesDescubierto;
        }

        public override void Extraer(double monto)
        {
            if (monto > saldo + topeDescubierto)
            {
                Console.WriteLine("No se puede extraer más dinero del que hay en la cuenta");
            }
            else
            {
                saldo -= monto;

                if (saldo < 0)
                {
                    double intereses = saldo * interesesDescubierto / 100;
                    saldo += intereses;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            CuentaBancaria[] cuentas = new CuentaBancaria[10];

            for (int i = 0; i < 5; i++)
            {
                cuentas[i] = new CuentaAhorro(random.Next(1000, 10000), 2.5);
            }

            for (int i = 5; i < 10; i++)
            {
                cuentas[i] = new CuentaCorriente(random.Next(1000, 10000), 5000, 5);
            }

            for (int i = 0; i < 100; i++)
            {
                int indiceCuenta = random.Next(0, 10);
                double monto = random.Next(10, 10000);

                if (random.Next(0,2) == 0)
                {
                    cuentas[indiceCuenta].Depositar(monto);
                }
                else
                {
                    cuentas[indiceCuenta].Extraer(monto);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Saldo de la cuenta {0}: {1}", i+1, cuentas[i].ObtenerSaldo());

                if (cuentas[i] is CuentaAhorro)
                {
                    CuentaAhorro cuentaAhorro = (CuentaAhorro)cuentas[i];
                    cuentaAhorro.CalcularIntereses();

                    Console.WriteLine("Saldo de la cuenta {0} con intereses: {1}", i + 1, cuentaAhorro.ObtenerSaldo());
                }
            }
            Console.ReadLine();
        }
    }
}