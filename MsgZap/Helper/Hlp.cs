using System;
using System.Collections.Specialized;
using System.Data;

namespace MsgZap.Helper
{
    class Hlp
    {
        public String RandomIdGenerator()
        {
            String Id = "";
            String Rd = "";

            try
            {
                Rd = Guid.NewGuid().ToString();

                Id = "msg-" + RandomNumber(0, 99) + "-" + Rd;

                return Id;
            }
            finally
            {
                Id = "";
                Rd = "";
            }
        }

        public String TelFormat(String Telefone)
        {
            String Tel = "";

            if (Telefone.Length == 11 && Int32.Parse(Telefone.Substring(0, 1)) == 8 && Int32.Parse(Telefone.Substring(1, 1)) == 1)
            {
                Tel = "55" + Telefone;
            }
            else if (Telefone.Length == 10 && Int32.Parse(Telefone.Substring(0, 1)) == 1)
            {
                Tel = "558" + Telefone;
            }
            else if (Telefone.Length == 9 && Int32.Parse(Telefone.Substring(0, 1)) == 9)
            {
                Tel = "5581" + Telefone;
            }
            else if (Telefone.Length == 8 && Int32.Parse(Telefone.Substring(0, 1)) == 9 || Int32.Parse(Telefone.Substring(0, 1)) == 8)
            {
                Tel = "55819" + Telefone;
            }
            else if ((Telefone.Length == 9) && (Int32.Parse(Telefone.Substring(0, 1)) == 1 && Int32.Parse(Telefone.Substring(1, 1)) == 9 || Int32.Parse(Telefone.Substring(1, 1)) == 8))
            {
                for (int x = 0; x <= 8; x++)
                {
                    if (x == 0) { Tel = "55819";  }
                    else { Tel += Telefone[x]; }
                }
            }
            else if ((Telefone.Length == 10) && (Int32.Parse(Telefone.Substring(0, 1)) == 8 && Int32.Parse(Telefone.Substring(1, 1)) == 1 && (Int32.Parse(Telefone.Substring(2, 1)) == 8 || Int32.Parse(Telefone.Substring(2, 1)) == 9)))
            {
                for (int x = 0; x <= 9; x++)
                {
                    if (x == 0 || x == 1) { Tel = "55819"; }
                    else{ Tel += Telefone[x]; }
                }
            }
            else
            {
                Tel = "";
            }

            if (Tel.Length > 13 || Tel.Length < 13) { Tel = ""; }

            return Tel;
        }

        public String TelFind(DataTable Table,String Tabela, Int32 Cont)
        {
            String TelFound = "";

            if (Tabela == "ALUNO") {
                if (!String.IsNullOrEmpty(Table.Rows[Cont]["tel_celular"].ToString()))
                {
                    TelFound = Table.Rows[Cont]["tel_celular"].ToString();
                } else if (!String.IsNullOrEmpty(Table.Rows[Cont]["tel_recado"].ToString()))
                {
                    TelFound = Table.Rows[Cont]["tel_recado"].ToString();
                }
                else if (!String.IsNullOrEmpty(Table.Rows[Cont]["tel_residencia"].ToString()))
                {
                    TelFound = Table.Rows[Cont]["tel_recado"].ToString();
                }
                else if (!String.IsNullOrEmpty(Table.Rows[Cont]["tel_emergencia"].ToString()))
                {
                    TelFound = Table.Rows[Cont]["tel_emergencia"].ToString();
                }
                else if (!String.IsNullOrEmpty(Table.Rows[Cont]["tel_responsavel"].ToString()))
                {
                    TelFound = Table.Rows[Cont]["tel_responsavel"].ToString();
                }
                else if (!String.IsNullOrEmpty(Table.Rows[Cont]["tel_celular_responsavel"].ToString()))
                {
                    TelFound = Table.Rows[Cont]["tel_celular_responsavel"].ToString();
                }
                else
                {
                    TelFound = "";
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(Table.Rows[Cont]["tel_celular"].ToString()))
                {
                    TelFound = Table.Rows[Cont]["tel_celular"].ToString();
                }
                else if (!String.IsNullOrEmpty(Table.Rows[Cont]["tel_recado"].ToString()))
                {
                    TelFound = Table.Rows[Cont]["tel_recado"].ToString();
                }
                else if (!String.IsNullOrEmpty(Table.Rows[Cont]["tel_residencia"].ToString()))
                {
                    TelFound = Table.Rows[Cont]["tel_recado"].ToString();
                }
                else
                {
                    TelFound = "";
                }

            }

            return TelFound;
        }

        public NameValueCollection WinzapParameters()
        {
            NameValueCollection WebFields = null;

            return WebFields;
            
        }

        public String DateFormat(String DateAnt)
        {
            String Date = "";
            String[] DatePart;

            DatePart = DateAnt.Split('/');
            Date = DatePart[2] + "-" + DatePart[1] + "-" + DatePart[0];

            return Date;
        }

        public Int32 WaitTime(Int32 Contador) {

            Int32 Time = 0;

            if (Contador < 200) 
            {
                Time = 5000;
            } else if (Contador == 200) 
            {
                Time = (30 * 1000);
            } else if (Contador > 200 && Contador < 600)
            {
                Time = 8000;
            } else if (Contador == 600)
            {
                Time = (60 * 1000);
            } else if (Contador > 600 && Contador < 1000)
            {
                Time = 10000;
            } else if (Contador == 1000)
            {
                Time = (120 * 1000);
            } else 
            {
                Time = 5000;
            }

            return Time;
        }

        public String RandomTalk() 
        {
            String Talk = "";
            Int32 Num = RandomNumber(1, 8);

            switch (Num) {
                case 1: {
                        Talk = "Bom dia";
                        break;
                    }
                case 2: {
                        Talk = "Olá tudo bem?";
                        break;
                    }
                case 3: {
                        Talk = "Como vai?";
                        break;
                    }
                case 4: {
                        Talk = "Olá";
                        break;
                    }
                case 5: {
                        Talk = "Oi tudo bem?";
                        break;
                    }
                case 6: {
                        Talk = "Olá, Como vai?";
                        break;
                    }
                case 7: {
                        Talk = "Bom dia, Como vai?";
                        break;
                    }
                case 8: {
                        Talk = "Tudo Bem?";
                        break;
                    }

            }


            return Talk;
        }

        public String RandomTalk(String Nome)
        {
            String Talk = "";
            Int32 Num = RandomNumber(1, 13);

            switch (Num) {
                case 1: {
                        Talk = "Bom dia " + Nome + " Tudo bem com você ?";
                        break;
                }
                case 2: {
                        Talk = "Olá tudo bem? " + Nome;
                        break;
                }
                case 3: {
                        Talk = "Como vai? " + Nome;
                        break;
                }
                case 4: {
                        Talk = "Olá " + Nome;
                        break;
                }
                case 5: {
                        Talk = "Oi tudo bem? " + Nome;
                        break;
                }
                case 6: {
                        Talk = "Olá, Como vai? " + Nome;
                        break;
                }
                case 7: {
                        Talk = "Bom dia, Como vai? " + Nome;
                        break;
                }
                case 8: {
                        Talk = "Tudo Bem? " + Nome;
                        break;
                }
                case 9: {
                        Talk = "Olá " + Nome + " Como vai?";
                        break;
                }
                case 10: {
                        Talk = "Olá " + Nome + " Tudo bem?";
                        break;
                }
                case 11: {
                        Talk = Nome + " Como vai?" ;
                        break;
                }
                case 12: {
                        Talk = "Olá "+ Nome + " Tudo Bem com você?";
                        break;
                }
                case 13:
                {
                    Talk = "Bom dia " + Nome + " Como vai? ";
                    break;
                }

            }


            return Talk;
        }

        public int RandomNumber(int min, int max) 
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}
