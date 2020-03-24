using ElevadorApp.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevadorApp
{
    public partial class Principal : Form
    {
        private int Contador;
        private int Cont;
        private int Ancho;
        private int Largo;
        private int XElevador;
        private int YElevador;
        private int X;
        private int Y;
        private int PisoReferencia;
        private int PesoElevador;
        private int PersonasElevador;
        private int CantidadPersonas;
        private int Total;
        private int CantidadMontados;
        private int CantidadDesmontados;
        private Persona lobbyUno;
        private Persona lobbyDos;
        private Persona lobbyTres;
        private Persona lobbyCuatro;
        private Persona lobbyCinco;
        private Persona lobbySeis;
        private Persona lobbySiete;
        private Persona lobbyOcho;
        private Persona lobbyNueve;
        private Persona lobbyDiez;
        private Persona PrimerUno;
        private Persona PrimerDos;
        private Persona PrimerTres;
        private Persona SegundoUno;
        private Persona SegundoDos;
        private Persona SegndoTres;
        private Persona TercerUno;
        private Persona TercerDos;
        private Persona TercerTres;
        private Persona CuartoUno;
        private Persona CuartoDos;
        private Persona CuartoTres;
        private Persona QuintoUno;
        private Persona QuintoDos;
        private Persona QuintoTres;

        public Principal()
        {
            InitializeComponent();
            Contador = 0;
            Cont = 5;
            X = 684;
            Y = 520;
            Ancho = 102;
            Largo = 74;
            ElevadorPictureBox.SetBounds(X, Y, Ancho, Largo);
            PisoTextBox.Text = "0";
            PisoReferencia = 0;
            CantidadDesmontados = 0;
        }

        //Métodos.
        private void TiempoCambio()
        {
            int num = ToInt(PisoTextBox.Text);
            Thread thread = new Thread(SubirPosicion);
            thread.Start();
            Thread.Sleep(2000);
        }

        private void ContarDesmontados()
        {
            List<Persona> lista = new List<Persona>();

            if (HistorialDataGridView.DataSource != null)
            {
                lista = (List<Persona>)HistorialDataGridView.DataSource;
            }

            foreach (var item in lista)
            {
                if (item.Estado == "Desmontado")
                {
                }
            }
        }

        private void Desmontar()
        {
            List<Persona> lista = new List<Persona>();

            if (HistorialDataGridView.DataSource != null)
            {
                lista = (List<Persona>)HistorialDataGridView.DataSource;
            }

            foreach (var item in lista)
            {
                if (item.Estado == "Montado" && item.Piso == PisoReferencia)
                {
                    item.Estado = "Desmontado";
                    CantidadPersonas -= 1;
                    CantidadDesmontados += 1;
                    PersonasTextBox.Text = CantidadPersonas.ToString();
                    DesmontadosTextBox.Text = CantidadDesmontados.ToString();
                }
            }
        }

        private void CargarPersonas()
        {
            lobbyUno = new Persona();
            lobbyDos = new Persona();
            lobbyTres = new Persona();
            lobbyCuatro = new Persona();
            lobbyCinco = new Persona();
            lobbySeis = new Persona();
            lobbySiete = new Persona();
            lobbyOcho = new Persona();
            lobbyNueve = new Persona();
            lobbyDiez = new Persona();
            PrimerUno = new Persona();
            PrimerDos = new Persona();
            PrimerTres = new Persona();
            SegundoUno = new Persona();
            SegundoDos = new Persona();
            SegndoTres = new Persona();
            TercerUno = new Persona();
            TercerDos = new Persona();
            TercerTres = new Persona();
            CuartoUno = new Persona();
            CuartoDos = new Persona();
            CuartoTres = new Persona();
            QuintoUno = new Persona();
            QuintoDos = new Persona();
            QuintoTres = new Persona();

            lobbyUno.PersonaId = 1;
            lobbyUno.Nombre = "Persona 1 del Lobby";
            lobbyUno.Peso = ToInt(UnoLobbyTextBox.Text);
            lobbyUno.Piso = ToInt(PisoLobbyUnoTextBox.Text);
            lobbyUno.Estado = "En espera";

            lobbyDos.PersonaId = 2;
            lobbyDos.Nombre = "Persona 2 del Lobby";
            lobbyDos.Peso = ToInt(DosLobbyTextBox.Text);
            lobbyDos.Piso = ToInt(PisoLobbyDosTextBox.Text);
            lobbyDos.Estado = "En espera";

            lobbyTres.PersonaId = 3;
            lobbyTres.Nombre = "Persona 3 del Lobby";
            lobbyTres.Peso = ToInt(TresLobbyTextBox.Text);
            lobbyTres.Piso = ToInt(PisoLobbyTresTextBox.Text);
            lobbyTres.Estado = "En espera";

            lobbyCuatro.PersonaId = 4;
            lobbyCuatro.Nombre = "Persona 4 del Lobby";
            lobbyCuatro.Peso = ToInt(CuatroLobbyTextBox.Text);
            lobbyCuatro.Piso = ToInt(PisoLobbyCuatroTextBox.Text);
            lobbyCuatro.Estado = "En espera";

            lobbyCinco.PersonaId = 5;
            lobbyCinco.Nombre = "Persona 5 del Lobby";
            lobbyCinco.Peso = ToInt(CincoLobbyTextBox.Text);
            lobbyCinco.Piso = ToInt(PisoLobbyCincoTextBox.Text);
            lobbyCinco.Estado = "En espera";

            lobbySeis.PersonaId = 6;
            lobbySeis.Nombre = "Persona 6 del Lobby";
            lobbySeis.Peso = ToInt(SeisLobbyTextBox.Text);
            lobbySeis.Piso = ToInt(PisoLobbySeisTextBox.Text);
            lobbySeis.Estado = "En espera";

            lobbySiete.PersonaId = 7;
            lobbySiete.Nombre = "Persona 7 del Lobby";
            lobbySiete.Peso = ToInt(SieteLobbyTextBox.Text);
            lobbySiete.Piso = ToInt(PisoLobbySieteTextBox.Text);
            lobbySiete.Estado = "En espera";

            lobbyOcho.PersonaId = 8;
            lobbyOcho.Nombre = "Persona 8 del Lobby";
            lobbyOcho.Peso = ToInt(OchoLobbyTextBox.Text);
            lobbyOcho.Piso = ToInt(PisoLobbyOchoTextBox.Text);
            lobbyOcho.Estado = "En espera";

            lobbyNueve.PersonaId = 9;
            lobbyNueve.Nombre = "Persona 9 del Lobby";
            lobbyNueve.Peso = ToInt(NueveLobbyTextBox.Text);
            lobbyNueve.Piso = ToInt(PisoLobbyNueveTextBox.Text);
            lobbyNueve.Estado = "En espera";

            lobbyDiez.PersonaId = 10;
            lobbyDiez.Nombre = "Persona 10 del Lobby";
            lobbyDiez.Peso = ToInt(DiezLobbyTextBox.Text);
            lobbyDiez.Piso = ToInt(PisoLobbyDiezTextBox.Text);
            lobbyDiez.Estado = "En espera";

            PrimerUno.PersonaId = 11;
            PrimerUno.Nombre = "Persona 1 del Primer Piso";
            PrimerUno.Peso = ToInt(PrimerUnoTextBox.Text);
            PrimerUno.Piso = ToInt(PrimerPisoUnoTextBox.Text);
            PrimerUno.Estado = "En espera";

            PrimerDos.PersonaId = 12;
            PrimerDos.Nombre = "Persona 2 del Primer Piso";
            PrimerDos.Peso = ToInt(PrimerDosTextBox.Text);
            PrimerDos.Piso = ToInt(PrimerPisoDosTextBox.Text);
            PrimerDos.Estado = "En espera";

            PrimerTres.PersonaId = 13;
            PrimerTres.Nombre = "Persona 3 del Primer Piso";
            PrimerTres.Peso = ToInt(PrimerTresTextBox.Text);
            PrimerTres.Piso = ToInt(PrimerPisoTresTextBox.Text);
            PrimerTres.Estado = "En espera";

            SegundoUno.PersonaId = 21;
            SegundoUno.Nombre = "Persona 1 del Segundo Piso";
            SegundoUno.Peso = ToInt(SegundoUnoTextBox.Text);
            SegundoUno.Piso = ToInt(SegundoPisoUnoTextBox.Text);
            SegundoUno.Estado = "En espera";

            SegundoDos.PersonaId = 22;
            SegundoDos.Nombre = "Persona 2 del Segundo Piso";
            SegundoDos.Peso = ToInt(SegundoDosTextBox.Text);
            SegundoDos.Piso = ToInt(SegundoPisoDosTextBox.Text);
            SegundoDos.Estado = "En espera";

            SegndoTres.PersonaId = 23;
            SegndoTres.Nombre = "Persona 3 del Segundo Piso";
            SegndoTres.Peso = ToInt(SegundoTresTextBox.Text);
            SegndoTres.Piso = ToInt(SegundoPisoTresTextBox.Text);
            SegndoTres.Estado = "En espera";

            TercerUno.PersonaId = 31;
            TercerUno.Nombre = "Persona 1 del Tercer Piso";
            TercerUno.Peso = ToInt(TercerUnoTextBox.Text);
            TercerUno.Piso = ToInt(TercerPisoUnoTextBox.Text);
            TercerUno.Estado = "En espera";

            TercerDos.PersonaId = 32;
            TercerDos.Nombre = "Persona 2 del Tercer Piso";
            TercerDos.Peso = ToInt(TercerDosTextBox.Text);
            TercerDos.Piso = ToInt(TercerPisoDosTextBox.Text);
            TercerDos.Estado = "En espera";

            TercerTres.PersonaId = 33;
            TercerTres.Nombre = "Persona 3 del Tercer Piso";
            TercerTres.Peso = ToInt(TercerTresTextBox.Text);
            TercerTres.Piso = ToInt(TercerPisoTresTextBox.Text);
            TercerTres.Estado = "En espera";

            CuartoUno.PersonaId = 41;
            CuartoUno.Nombre = "Persona 1 del Cuarto Piso";
            CuartoUno.Peso = ToInt(CuartoUnoTextBox.Text);
            CuartoUno.Piso = ToInt(CuartoPisoUnoTextBox.Text);
            CuartoUno.Estado = "En espera";

            CuartoDos.PersonaId = 42;
            CuartoDos.Nombre = "Persona 2 del Cuarto Piso";
            CuartoDos.Peso = ToInt(CuartoDosTextBox.Text);
            CuartoDos.Piso = ToInt(CuartoPisoDosTextBox.Text);
            CuartoDos.Estado = "En espera";

            CuartoTres.PersonaId = 43;
            CuartoTres.Nombre = "Persona 3 del Cuarto Piso";
            CuartoTres.Peso = ToInt(CuartoTresTextBox.Text);
            CuartoTres.Piso = ToInt(CuartoPisoTresTextBox.Text);
            CuartoTres.Estado = "En espera";

            QuintoUno.PersonaId = 51;
            QuintoUno.Nombre = "Persona 1 del Quinto Piso";
            QuintoUno.Peso = ToInt(QuintoUnoTextBox.Text);
            QuintoUno.Piso = ToInt(QuintoPisoUnoTextBox.Text);
            QuintoUno.Estado = "En espera";

            QuintoDos.PersonaId = 52;
            QuintoDos.Nombre = "Persona 2 del Quinto Piso";
            QuintoDos.Peso = ToInt(QuintoDosTextBox.Text);
            QuintoDos.Piso = ToInt(QuintoPisoDosTextBox.Text);
            QuintoDos.Estado = "En espera";

            QuintoTres.PersonaId = 53;
            QuintoTres.Nombre = "Persona 3 del Quinto Piso";
            QuintoTres.Peso = ToInt(QuintoTresTextBox.Text);
            QuintoTres.Piso = ToInt(QuintoPisoTresTextBox.Text);
            QuintoTres.Estado = "En espera";

        }

        private void CargarElevador()
        {
            int pesso;
            pesso = 0;
            pesso = Total;
            int pesoEvaluar = ToInt(LimitePesoTextBox.Text);
            int limitePersonas = ToInt(LimitePersonasTextBox.Text);

            if (PisoReferencia == 0)
            {
                pesso = lobbyUno.Peso;
                if (pesso < pesoEvaluar && CantidadPersonas < limitePersonas)
                {
                    if (lobbyUno.Estado == "En espera")
                    {
                        lobbyUno.Estado = "Montado";
                        CargarGrid(lobbyUno);
                    }
                    if (CantidadPersonas < limitePersonas && (pesso + lobbyDos.Peso) < pesoEvaluar && lobbyDos.Estado == "En espera")
                    {
                        pesso += lobbyDos.Peso;
                        lobbyDos.Estado = "Montado";
                        CargarGrid(lobbyDos);
                    }
                    if (CantidadPersonas < limitePersonas && (pesso + lobbyTres.Peso) < pesoEvaluar && lobbyTres.Estado == "En espera")
                    {
                        pesso += lobbyTres.Peso;
                        lobbyTres.Estado = "Montado";
                        CargarGrid(lobbyTres);
                    }
                    if (CantidadPersonas < limitePersonas && (pesso + lobbyCuatro.Peso) < pesoEvaluar && lobbyCuatro.Estado == "En espera")
                    {
                        pesso += lobbyCuatro.Peso;
                        lobbyCuatro.Estado = "Montado";
                        CargarGrid(lobbyCuatro);
                    }
                    if (CantidadPersonas < limitePersonas && (pesso + lobbyCinco.Peso) < pesoEvaluar && lobbyCinco.Estado == "En espera")
                    {
                        pesso += lobbyCinco.Peso;
                        lobbyCinco.Estado = "Montado";
                        CargarGrid(lobbyCinco);
                    }
                    if (CantidadPersonas < limitePersonas && (pesso + lobbySeis.Peso) < pesoEvaluar && lobbySeis.Estado == "En espera")
                    {
                        pesso += lobbySeis.Peso;
                        lobbySeis.Estado = "Montado";
                        CargarGrid(lobbySeis);
                    }
                    if (CantidadPersonas < limitePersonas && (pesso + lobbySiete.Peso) < pesoEvaluar && lobbySiete.Estado == "En espera")
                    {
                        pesso += lobbySiete.Peso;
                        lobbySiete.Estado = "Montado";
                        CargarGrid(lobbySiete);
                    }
                    if (CantidadPersonas < limitePersonas && (pesso + lobbyOcho.Peso) < pesoEvaluar && lobbyOcho.Estado == "En espera")
                    {
                        pesso += lobbyOcho.Peso;
                        lobbyOcho.Estado = "Montado";
                        CargarGrid(lobbyOcho);
                    }
                    if (CantidadPersonas < limitePersonas && (pesso + lobbyNueve.Peso) < pesoEvaluar && lobbyNueve.Estado == "En espera")
                    {
                        pesso += lobbyNueve.Peso;
                        lobbyNueve.Estado = "Montado";
                        CargarGrid(lobbyNueve);
                    }
                    if (CantidadPersonas < limitePersonas && (pesso + lobbyDiez.Peso) < pesoEvaluar && lobbyDiez.Estado == "En espera")
                    {
                        pesso += lobbyDiez.Peso;
                        lobbyDiez.Estado = "Montado";
                        CargarGrid(lobbyDiez);
                    }
                }
            }

            if (PisoReferencia == 1)
            {
                if ((pesso + PrimerUno.Peso) < pesoEvaluar && CantidadPersonas < limitePersonas && PrimerUno.Estado == "En espera")
                {
                    pesso += PrimerUno.Peso;
                    PrimerUno.Estado = "Montado";
                    CargarGrid(PrimerUno);
                }
                if ((pesso + PrimerDos.Peso) < pesoEvaluar && CantidadPersonas < limitePersonas && PrimerDos.Estado == "En espera")
                {
                    pesso += PrimerDos.Peso;
                    PrimerDos.Estado = "Montado";
                    CargarGrid(PrimerDos);
                }
                if ((pesso + PrimerTres.Peso) < pesoEvaluar && CantidadPersonas < limitePersonas && PrimerTres.Estado == "En espera")
                {
                    pesso += PrimerTres.Peso;
                    PrimerTres.Estado = "Montado";
                    CargarGrid(PrimerTres);
                }
            }

            if (PisoReferencia == 2)
            {
                if ((pesso + SegundoUno.Peso) < pesoEvaluar && CantidadPersonas < limitePersonas && SegundoUno.Estado == "En espera")
                {
                    pesso += SegundoUno.Peso;
                    SegundoUno.Estado = "Montado";
                    CargarGrid(SegundoUno);
                }
                if ((pesso + SegundoDos.Peso) < pesoEvaluar && CantidadPersonas < limitePersonas && SegundoDos.Estado == "En espera")
                {
                    pesso += SegundoDos.Peso;
                    SegundoDos.Estado = "Montado";
                    CargarGrid(SegundoDos);
                }
                if ((pesso + SegndoTres.Peso) < pesoEvaluar && CantidadPersonas < limitePersonas && SegndoTres.Estado == "En espera")
                {
                    pesso += SegndoTres.Peso;
                    SegndoTres.Estado = "Montado";
                    CargarGrid(SegndoTres);
                }
            }

            if (PisoReferencia == 3)
            {
                if (CantidadPersonas < limitePersonas && (pesso + TercerUno.Peso) < pesoEvaluar && TercerUno.Estado == "En espera")
                {
                    pesso += TercerUno.Peso;
                    TercerUno.Estado = "Montado";
                    CargarGrid(TercerUno);
                }
                if (CantidadPersonas < limitePersonas && (pesso + TercerDos.Peso) < pesoEvaluar && TercerDos.Estado == "En espera")
                {
                    pesso += TercerDos.Peso;
                    TercerDos.Estado = "Montado";
                    CargarGrid(TercerDos);
                }
                if (CantidadPersonas < limitePersonas && (pesso + TercerTres.Peso) < pesoEvaluar && TercerTres.Estado == "En espera")
                {
                    pesso += TercerTres.Peso;
                    TercerTres.Estado = "Montado";
                    CargarGrid(TercerTres);
                }
            }

            if (PisoReferencia == 4)
            {
                if (CantidadPersonas < limitePersonas && (pesso + CuartoUno.Peso) < pesoEvaluar && CuartoUno.Estado == "En espera")
                {
                    pesso += CuartoUno.Peso;
                    CuartoUno.Estado = "Montado";
                    CargarGrid(CuartoUno);
                }
                if (CantidadPersonas < limitePersonas && (pesso + CuartoDos.Peso) < pesoEvaluar && CuartoDos.Estado == "En espera")
                {
                    pesso += CuartoDos.Peso;
                    CuartoDos.Estado = "Montado";
                    CargarGrid(CuartoDos);
                }
                if (CantidadPersonas < limitePersonas && (pesso + CuartoTres.Peso) < pesoEvaluar && CuartoTres.Estado == "En espera")
                {
                    pesso += CuartoTres.Peso;
                    CuartoTres.Estado = "Montado";
                    CargarGrid(CuartoTres);
                }
            }

            if (PisoReferencia == 5)
            {
                if (CantidadPersonas < limitePersonas && (pesso + QuintoUno.Peso) < pesoEvaluar && QuintoUno.Estado == "En espera")
                {
                    pesso += QuintoUno.Peso;
                    QuintoUno.Estado = "Montado";
                    CargarGrid(QuintoUno);
                }
                if (CantidadPersonas < limitePersonas && (pesso + QuintoDos.Peso) < pesoEvaluar && QuintoDos.Estado == "En espera")
                {
                    pesso += QuintoDos.Peso;
                    QuintoDos.Estado = "Montado";
                    CargarGrid(QuintoDos);
                }
                if (CantidadPersonas < limitePersonas && (pesso + QuintoTres.Peso) < pesoEvaluar && QuintoTres.Estado == "En espera")
                {
                    pesso += QuintoTres.Peso;
                    QuintoTres.Estado = "Montado";
                    CargarGrid(QuintoTres);
                }
            }
        }

        private void CantidadPesoYPersonas()
        {
            List<Persona> detalle = new List<Persona>();
            List<Persona> lista = new List<Persona>();

            if (HistorialDataGridView.DataSource != null)
            {
                detalle = (List<Persona>)HistorialDataGridView.DataSource;
            }

            Total = 0;
            foreach (var item in detalle)
            {
                if (item.Estado == "Montado")
                {
                    Total += item.Peso;
                    lista.Add(item);
                }
            }
            CantidadPersonas = lista.Count();
            PesoTextBox.Text = Total.ToString();
            PersonasTextBox.Text = CantidadPersonas.ToString();
        }

        private void CargarGrid(Persona persona)
        {
            List<Persona> lista = new List<Persona>();

            if (HistorialDataGridView.DataSource != null)
            {
                lista = (List<Persona>)HistorialDataGridView.DataSource;
            }
            lista.Add(
                new Persona(
                   personaId: persona.PersonaId,
                   nombre: persona.Nombre,
                   peso: persona.Peso,
                   piso: persona.Piso,
                   estado: persona.Estado
           ));

            HistorialDataGridView.DataSource = null;
            HistorialDataGridView.DataSource = lista;
            HistorialDataGridView.Columns["PersonaId"].Visible = false;
            HistorialDataGridView.Columns[1].Width = 250;
            CantidadPesoYPersonas();
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        private void SubirPosicion()
        {
            int piso = Contador;

            if (piso == 0)
            {
                PisoReferencia = 0;
                ElevadorPictureBox.SetBounds(X, Y, Ancho, Largo);
            }

            if (piso == 1)
            {
                PisoReferencia = 1;
                ElevadorPictureBox.SetBounds(X, 428, Ancho, Largo);
            }

            if (piso == 2)
            {
                PisoReferencia = 2;
                ElevadorPictureBox.SetBounds(X, 336, Ancho, Largo);
            }

            if (piso == 3)
            {
                PisoReferencia = 3;
                ElevadorPictureBox.SetBounds(X, 244, Ancho, Largo);
            }

            if (piso == 4)
            {
                PisoReferencia = 4;
                ElevadorPictureBox.SetBounds(X, 152, Ancho, Largo);
            }

            if (piso == 5)
            {
                PisoReferencia = 5;
                ElevadorPictureBox.SetBounds(X, 60, Ancho, Largo);
            }

            //switch (piso)
            //{
            //    case 0:
            //        ElevadorPictureBox.SetBounds(X, Y, 104, 88);
            //        break;
            //    case 1:
            //        ElevadorPictureBox.SetBounds(X, 428, 104, 88);
            //        break;
            //    case 2:
            //        ElevadorPictureBox.SetBounds(X, 336, 104, 88);
            //        break;
            //    case 3:
            //        ElevadorPictureBox.SetBounds(X, 244, 104, 88);
            //        break;
            //    case 4:
            //        ElevadorPictureBox.SetBounds(X, 152, 104, 88);
            //        break;
            //    case 5:
            //        ElevadorPictureBox.SetBounds(X, 60, 104, 88);
            //        break;
            //}
        }

        private void BajarPosicion()
        {
            int piso = ToInt(PisoTextBox.Text);

            if (piso == 0)
            {
                PisoReferencia = 0;
                ElevadorPictureBox.SetBounds(X, Y, Ancho, Largo);
            }

            if (piso == 1)
            {
                PisoReferencia = 1;
                ElevadorPictureBox.SetBounds(X, 428, Ancho, Largo);
            }

            if (piso == 2)
            {
                PisoReferencia = 2;
                ElevadorPictureBox.SetBounds(X, 336, Ancho, Largo);
            }

            if (piso == 3)
            {
                PisoReferencia = 3;
                ElevadorPictureBox.SetBounds(X, 244, Ancho, Largo);
            }

            if (piso == 4)
            {
                PisoReferencia = 4;
                ElevadorPictureBox.SetBounds(X, 152, Ancho, Largo);
            }

            if (piso == 5)
            {
                PisoReferencia = 5;
                ElevadorPictureBox.SetBounds(X, 60, Ancho, Largo);
            }

            //switch (piso)
            //{
            //    case 0:
            //        ElevadorPictureBox.SetBounds(X, Y, 104, 88);
            //        break;
            //    case 1:
            //        ElevadorPictureBox.SetBounds(X, 428, 104, 88);
            //        break;
            //    case 2:
            //        ElevadorPictureBox.SetBounds(X, 336, 104, 88);
            //        break;
            //    case 3:
            //        ElevadorPictureBox.SetBounds(X, 244, 104, 88);
            //        break;
            //    case 4:
            //        ElevadorPictureBox.SetBounds(X, 152, 104, 88);
            //        break;
            //    case 5:
            //        ElevadorPictureBox.SetBounds(X, 60, 104, 88);
            //        break;
            //}
        }

        private void LlenarPiso()
        {
            PrimerPisoUnoTextBox.Text = EjemploRandom().ToString();
            PrimerPisoDosTextBox.Text = EjemploRandom().ToString();
            PrimerPisoTresTextBox.Text = EjemploRandom().ToString();

            SegundoPisoUnoTextBox.Text = EjemploRandom().ToString();
            SegundoPisoDosTextBox.Text = EjemploRandom().ToString();
            SegundoPisoTresTextBox.Text = EjemploRandom().ToString();

            TercerPisoUnoTextBox.Text = EjemploRandom().ToString();
            TercerPisoDosTextBox.Text = EjemploRandom().ToString();
            TercerPisoTresTextBox.Text = EjemploRandom().ToString();

            CuartoPisoUnoTextBox.Text = EjemploRandom().ToString();
            CuartoPisoDosTextBox.Text = EjemploRandom().ToString();
            CuartoPisoTresTextBox.Text = EjemploRandom().ToString();

            QuintoPisoUnoTextBox.Text = RandomPisoCinco().ToString();
            QuintoPisoDosTextBox.Text = RandomPisoCinco().ToString();
            QuintoPisoTresTextBox.Text = RandomPisoCinco().ToString();

            //Lobby
            PisoLobbyUnoTextBox.Text = RandomLobby().ToString();
            PisoLobbyDosTextBox.Text = RandomLobby().ToString();
            PisoLobbyTresTextBox.Text = RandomLobby().ToString();
            PisoLobbyCuatroTextBox.Text = RandomLobby().ToString();
            PisoLobbyCincoTextBox.Text = RandomLobby().ToString();
            PisoLobbySeisTextBox.Text = RandomLobby().ToString();
            PisoLobbySieteTextBox.Text = RandomLobby().ToString();
            PisoLobbyOchoTextBox.Text = RandomLobby().ToString();
            PisoLobbyNueveTextBox.Text = RandomLobby().ToString();
            PisoLobbyDiezTextBox.Text = RandomLobby().ToString();

        }

        private int Randommm()
        {
            int numero = 0;
            Random random = new Random();
            numero = random.Next(1, 6);
            return numero;
        }

        private int GetPiso()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            int value = random.Next(1, 6);
            int num = value;
            value = 0;
            return num;
        }

        private int RandomLobby()
        {
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));

            var random = new Random(seed);
            int value = random.Next(1, 6);

            return value;
        }

        private int RandomPisoCinco()
        {
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));

            var random = new Random(seed);
            int value = random.Next(0, 5);

            return value;
        }

        private int EjemploRandom()
        {
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));

            var random = new Random(seed);
            int value = random.Next(0, 6);

            return value;
        }

        private int RandomPeso()
        {
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));

            var random = new Random(seed);
            int value = random.Next(50, 250);

            return value;
        }

        private void LlenarPeso()
        {
            PrimerUnoTextBox.Text = RandomPeso().ToString();
            PrimerDosTextBox.Text = RandomPeso().ToString();
            PrimerTresTextBox.Text = RandomPeso().ToString();

            SegundoUnoTextBox.Text = RandomPeso().ToString();
            SegundoDosTextBox.Text = RandomPeso().ToString();
            SegundoTresTextBox.Text = RandomPeso().ToString();

            TercerUnoTextBox.Text = RandomPeso().ToString();
            TercerDosTextBox.Text = RandomPeso().ToString();
            TercerTresTextBox.Text = RandomPeso().ToString();

            CuartoUnoTextBox.Text = RandomPeso().ToString();
            CuartoDosTextBox.Text = RandomPeso().ToString();
            CuartoTresTextBox.Text = RandomPeso().ToString();

            QuintoUnoTextBox.Text = RandomPeso().ToString();
            QuintoDosTextBox.Text = RandomPeso().ToString();
            QuintoTresTextBox.Text = RandomPeso().ToString();

            //Lobby
            UnoLobbyTextBox.Text = RandomPeso().ToString();
            DosLobbyTextBox.Text = RandomPeso().ToString();
            TresLobbyTextBox.Text = RandomPeso().ToString();
            CuatroLobbyTextBox.Text = RandomPeso().ToString();
            CincoLobbyTextBox.Text = RandomPeso().ToString();
            SeisLobbyTextBox.Text = RandomPeso().ToString();
            SieteLobbyTextBox.Text = RandomPeso().ToString();
            OchoLobbyTextBox.Text = RandomPeso().ToString();
            NueveLobbyTextBox.Text = RandomPeso().ToString();
            DiezLobbyTextBox.Text = RandomPeso().ToString();
        }

        private bool Validar()
        {
            bool estado = false;
            int PesoValidar = ToInt(LimitePesoTextBox.Text);
            int PesoProm = 772;

            if (String.IsNullOrWhiteSpace(LimitePesoTextBox.Text))
            {
                MyErrorProvider.SetError(LimitePesoTextBox, "Debe establecer un Límite de Peso antes de iniciar");
                estado = true;
            }
            if (String.IsNullOrWhiteSpace(LimitePersonasTextBox.Text))
            {
                MyErrorProvider.SetError(LimitePersonasTextBox, "Debe establecer un Límite de Personas antes de iniciar");
                estado = true;
            }
            if (PesoValidar < PesoProm)
            {
                MyErrorProvider.SetError(LimitePesoTextBox, "Debe establecer un Límite de Peso mayor al del promedio.");
                MessageBox.Show("El peso promedio es de " + PesoProm.ToString() + " libras.");
                estado = true;
            }

            return estado;
        }

        //Eventos de los Controles.
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            Contador++;
            int num = ToInt(PisoTextBox.Text);
            if (num == 4)
            {
                MyTimer.Enabled = false;
                Cont = 5;
                MyOtherTimer.Enabled = true;
            }
            PisoTextBox.Text = Contador.ToString();
        }

        private void MyOtherTimer_Tick(object sender, EventArgs e)
        {
            Cont--;
            int num = ToInt(PisoTextBox.Text);
            if (num == 1)
            {
                MyOtherTimer.Enabled = false;
                Contador = 0;
                MyTimer.Enabled = true;
            }
            PisoTextBox.Text = Cont.ToString();
        }

        private void PisoTextBox_TextChanged(object sender, EventArgs e)
        {
            SubirPosicion();
            BajarPosicion();
            if (ToInt(PisoTextBox.Text) != 0)
            {
                CargarElevador();
                Desmontar();
                CantidadPesoYPersonas();

            }
            if (HistorialDataGridView.DataSource != null)
            {
                if (ToInt(PisoTextBox.Text) == 0)
                {
                    CargarElevador();
                    Desmontar();
                    CantidadPesoYPersonas();
                }
            }
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                MessageBox.Show("Debe llenar los Límites");
                return;
            }
            else
            {
                MyErrorProvider.Clear();

                if (MyTimer.Enabled != true)
                    IniciarButton.Enabled = true;
                else
                {
                    MessageBox.Show("No puede iniciar si está en curso");
                    return;
                }
                MyTimer.Enabled = true;
                LlenarPiso();
                LlenarPeso();
                CargarPersonas();
                CargarElevador();
                //MyOtherTimer.Enabled = true;
                //TiempoCambio();
                LimitePesoTextBox.ReadOnly = true;
                LimitePersonasTextBox.ReadOnly = true;
                IniciarButton.Enabled = false;
            }
        }

        private void ReiniciarButton_Click(object sender, EventArgs e)
        {
            LimitePesoTextBox.ReadOnly = false;
            LimitePersonasTextBox.ReadOnly = false;
            IniciarButton.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarButton.Enabled = true;
            MyTimer.Enabled = false;
            MyOtherTimer.Enabled = false;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
        }
    }
}