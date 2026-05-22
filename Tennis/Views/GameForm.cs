using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using Tennis.Controllers;

namespace Tennis.Views
{
    public partial class GameForm : Form
    {
        private readonly GameController _controller;
        private readonly Timer _gameTimer;

        public GameForm()
        {
            InitializeComponent();

            // Initialisation
            _controller = new GameController(ClientSize.Width, ClientSize.Height);

            // Configuration du timer
            _gameTimer = new Timer
            {
                Interval = 16 // Environ 60 FPS
            };
            _gameTimer.Tick += GameLoop;
            _gameTimer.Start();
        }

        private void GameLoop(object sender, EventArgs e)
        {
            // Mettre à jour la position de la balle
            _controller.UpdateBallPosition();

            // Rafraîchir l'affichage
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            // Dessiner la balle
            g.FillEllipse(Brushes.Red, _controller.Ball.X, _controller.Ball.Y, 20, 20);

            // Dessiner les scores
            g.DrawString($"Player 1: {_controller.Player1.Score}", Font, Brushes.Black, 10, 10);
            g.DrawString($"Player 2: {_controller.Player2.Score}", Font, Brushes.Black, ClientSize.Width - 100, 10);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            // Déplacer les raquettes (si implémentées)
            // Exemple : Ajouter des contrôles pour les joueurs
        }
    }
}
