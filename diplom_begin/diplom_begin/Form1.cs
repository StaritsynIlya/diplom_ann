using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
namespace diplom_begin
{
    public partial class Form1 : Form //нумерация объектов
    {
        private const int 
            // Объекты природы не используещиеся для движения
            DIRT = 0, TREE = 1, SAND = 2, ROAD = 3,
            // Точка начала, конца, путь
            DOT_A = 4, DOT_B = 5, WAY = 6,

            // Водные объекты разной глубины с безопасными погодными условиями
            WATER_1_SAFE = 7,   WATER_2_SAFE = 8, 
            WATER_3_SAFE = 9,   WATER_4_SAFE = 10,  WATER_5_SAFE = 11, 
            WATER_6_SAFE = 12,  WATER_7_SAFE = 13,  WATER_8_SAFE = 14, 
            WATER_9_SAFE = 15,  WATER_10_SAFE = 16, WATER_11_SAFE = 17, 
            WATER_12_SAFE = 18, WATER_13_SAFE = 19, WATER_14_SAFE = 20, 
            WATER_15_SAFE = 21, WATER_16_SAFE = 22, WATER_17_SAFE = 23, 
            WATER_18_SAFE = 24, WATER_19_SAFE = 25, WATER_20_SAFE = 26,
            WATER_21_SAFE = 27, WATER_22_SAFE = 28, WATER_23_SAFE = 29, 
            WATER_24_SAFE = 30, WATER_25_SAFE = 31, WATER_26_SAFE = 32,

            // Водные объекты разной глубины с погодными условиями средней опасности
            WATER_1_NORMAL = 33,  WATER_2_NORMAL = 34,
            WATER_3_NORMAL = 35,  WATER_4_NORMAL = 36,  WATER_5_NORMAL = 37,
            WATER_6_NORMAL = 38,  WATER_7_NORMAL = 39,  WATER_8_NORMAL = 40, 
            WATER_9_NORMAL = 41,  WATER_10_NORMAL = 42, WATER_11_NORMAL = 43, 
            WATER_12_NORMAL = 44, WATER_13_NORMAL = 45, WATER_14_NORMAL = 46, 
            WATER_15_NORMAL = 47, WATER_16_NORMAL = 48, WATER_17_NORMAL = 49, 
            WATER_18_NORMAL = 50, WATER_19_NORMAL = 51, WATER_20_NORMAL = 52, 
            WATER_21_NORMAL = 53, WATER_22_NORMAL = 54, WATER_23_NORMAL = 55, 
            WATER_24_NORMAL = 56, WATER_25_NORMAL = 57, WATER_26_NORMAL = 58,

            // Водные объекты разной глубины с опасными погодными условиями 
            WATER_1_DANGER = 59,  WATER_2_DANGER = 60,
            WATER_3_DANGER = 61,  WATER_4_DANGER = 62,  WATER_5_DANGER = 63,
            WATER_6_DANGER = 64,  WATER_7_DANGER = 65,  WATER_8_DANGER = 66,
            WATER_9_DANGER = 67,  WATER_10_DANGER = 68, WATER_11_DANGER = 69,
            WATER_12_DANGER = 70, WATER_13_DANGER = 71, WATER_14_DANGER = 72,
            WATER_15_DANGER = 73, WATER_16_DANGER = 74, WATER_17_DANGER = 75,
            WATER_18_DANGER = 76, WATER_19_DANGER = 77, WATER_20_DANGER = 78,
            WATER_21_DANGER = 79, WATER_22_DANGER = 80, WATER_23_DANGER = 81,
            WATER_24_DANGER = 82, WATER_25_DANGER = 83, WATER_26_DANGER = 84;

        private readonly Color[] colorsList = //цвета объектов в RGB
        {
            // Цвета объектов природы не используещихся для движения
            Color.FromArgb(185, 122, 87), Color.FromArgb(181, 230 ,29), Color.FromArgb(239, 228, 176), Color.FromArgb(195, 195, 195),
            // Цвета точек начала, конца, путь
            Color.FromArgb(255, 0, 0), Color.FromArgb(254, 0, 0), Color.FromArgb(0, 255, 0),
            
            // Цвета водных объектов разной глубины с безопасными погодными условиями
            Color.FromArgb(250, 250, 255), Color.FromArgb(240, 240, 255),
            Color.FromArgb(230, 230, 255), Color.FromArgb(220, 220, 255),
            Color.FromArgb(210, 210, 255), Color.FromArgb(200, 200, 255),
            Color.FromArgb(190, 190, 255), Color.FromArgb(180, 180, 255),
            Color.FromArgb(170, 170, 255), Color.FromArgb(160, 160, 255),
            Color.FromArgb(150, 150, 255), Color.FromArgb(140, 140, 255),
            Color.FromArgb(130, 130, 255), Color.FromArgb(120, 120, 255),
            Color.FromArgb(110, 110, 255), Color.FromArgb(100, 100, 255),
            Color.FromArgb(90, 90, 255),   Color.FromArgb(80, 80, 255),
            Color.FromArgb(70, 70, 255),   Color.FromArgb(60, 60, 255),
            Color.FromArgb(50, 50, 255),   Color.FromArgb(40, 40, 255),
            Color.FromArgb(30, 30, 255),   Color.FromArgb(20, 20, 255),
            Color.FromArgb(10, 10, 255),   Color.FromArgb(0, 0, 255),
            
            // Цвета водных объектов разной глубины с погодными условиями средней опасности
            Color.FromArgb(255, 255, 250), Color.FromArgb(255, 255, 240),
            Color.FromArgb(255, 255, 230), Color.FromArgb(255, 255, 220),
            Color.FromArgb(255, 255, 210), Color.FromArgb(255, 255, 200),
            Color.FromArgb(255, 255, 190), Color.FromArgb(255, 255, 180),
            Color.FromArgb(255, 255, 170), Color.FromArgb(255, 255, 160),
            Color.FromArgb(255, 255, 150), Color.FromArgb(255, 255, 140),
            Color.FromArgb(255, 255, 130), Color.FromArgb(255, 255, 120),
            Color.FromArgb(255, 255, 110), Color.FromArgb(255, 255, 100),
            Color.FromArgb(255, 255, 90), Color.FromArgb(255, 255, 80),
            Color.FromArgb(255, 255, 70), Color.FromArgb(255, 255, 60),
            Color.FromArgb(255, 255, 50), Color.FromArgb(255, 255, 40),
            Color.FromArgb(255, 255, 30), Color.FromArgb(255, 255, 20),
            Color.FromArgb(255, 255, 10), Color.FromArgb(255, 255, 0),

            // Цвета водных объектов разной глубины с опасными погодными условиями 
            Color.FromArgb(250, 255, 250), Color.FromArgb(240, 255, 240),
            Color.FromArgb(230, 255, 230), Color.FromArgb(220, 255, 220),
            Color.FromArgb(210, 255, 210), Color.FromArgb(200, 255, 200),
            Color.FromArgb(190, 255, 190), Color.FromArgb(180, 255, 180),
            Color.FromArgb(170, 255, 170), Color.FromArgb(160, 255, 160),
            Color.FromArgb(150, 255, 150), Color.FromArgb(140, 255, 140),
            Color.FromArgb(130, 255, 130), Color.FromArgb(120, 255, 120),
            Color.FromArgb(110, 255, 110), Color.FromArgb(100, 255, 100),
            Color.FromArgb(90, 255, 90),   Color.FromArgb(80, 255, 80),
            Color.FromArgb(70, 255, 70),   Color.FromArgb(60, 255, 60),
            Color.FromArgb(50, 255, 50),   Color.FromArgb(40, 255, 40),
            Color.FromArgb(30, 255, 30),   Color.FromArgb(20, 255, 20),
            Color.FromArgb(10, 255, 10),   Color.FromArgb(0, 255, 0)
        };

        private (int x, int y)[] neighbourhood = {
            (0, 0),  // штиль 0
            (0, 1),  // север 1 
            (1, 1),  // северо-восток 2
            (1, 0),  // восток 3
            (1, -1), // юго-восток 4
            (0, -1),  // юг 5
            (-1, -1), // юго-запад 6
            (-1, 0),  // запад 7
            (-1, 1)   // северо-запад 8
        };

        private (int x, int y) selectedWindDirection = (0, 0);

        private int nx = 1, ny = 1, ia = 1, ja = 1, ib = 1, jb = 1;
        private int[,] X, count;
        private Node[,] grid;
        private double osad = 3;
        private bool isFirstClick = true;

        public class Node
        {
            public int X { get; set; }
            public int Y { get; set; }
            public bool IsWall { get; set; }
            public float Price { get; set; }
            public int GCost { get; set; }
            public int HCost { get; set; }
            public int FCost { get { return GCost + HCost; } }
            public Node Parent { get; set; }

            public Node(int x, int y, bool isWall, float price = 0)
            {
                X = x;
                Y = y;
                IsWall = isWall;
                Price = isWall ? 0 : price; ; 
            }
        }

        private void north_Click(object sender, EventArgs e)
        {
            selectedWindDirection = neighbourhood[1];
        }

        private void southeast_Click(object sender, EventArgs e)
        {
            selectedWindDirection = neighbourhood[4];
        }

        private void southwest_Click(object sender, EventArgs e)
        {
            selectedWindDirection = neighbourhood[6];
        }

        private void northwest_Click(object sender, EventArgs e)
        {
            selectedWindDirection = neighbourhood[8];
        }

        private void northeast_Click(object sender, EventArgs e)
        {
            selectedWindDirection = neighbourhood[2];
        }

        private void east_Click(object sender, EventArgs e)
        {
            selectedWindDirection = neighbourhood[3];
        }

        private void west_Click(object sender, EventArgs e)
        {
            selectedWindDirection = neighbourhood[7];
        }

        private void south_Click(object sender, EventArgs e)
        {
            selectedWindDirection = neighbourhood[5];
        }

        private void calm_Click(object sender, EventArgs e)
        {
            selectedWindDirection = neighbourhood[0];
        }

        public class AStar // алгоритм просчета пути A*
        {
            private Node[,] _grid;
            private List<Node> _openList;
            private List<Node> _closedList;

            public AStar(Node[,] grid)
            {
                _grid = grid;
                _openList = new List<Node>();
                _closedList = new List<Node>();
            }

            private List<Node> GetNeighbors(Node node)
            {
                List<Node> neighbor = new List<Node>();
                if (node.X > 0)
                {
                    neighbor.Add(_grid[node.X - 1, node.Y]);
                }
                if ((node.X > 0) && (node.Y > 0))
                {
                    neighbor.Add(_grid[node.X - 1, node.Y - 1]);
                }
                if (node.X < _grid.GetLength(0) - 1)
                {
                    neighbor.Add(_grid[node.X + 1, node.Y]);
                }
                if ((node.X < _grid.GetLength(0) - 1) && (node.Y <
                _grid.GetLength(1) - 1))
                {
                    neighbor.Add(_grid[node.X + 1, node.Y + 1]);
                }
                if (node.Y > 0)
                {
                    neighbor.Add(_grid[node.X, node.Y - 1]);
                }
                if ((node.X < _grid.GetLength(0) - 1) && (node.Y > 0))
                {
                    neighbor.Add(_grid[node.X + 1, node.Y - 1]);
                }
                if (node.Y < _grid.GetLength(1) - 1)
                {
                    neighbor.Add(_grid[node.X, node.Y + 1]);
                }
                if ((node.Y < _grid.GetLength(0) - 1) && (node.X > 0))
                {
                    neighbor.Add(_grid[node.X - 1, node.Y + 1]);
                }
                return neighbor;
            }
            public List<Node> FindPath(Node startNode, Node endNode, int windX, int windY)
            {
                if (startNode == null || endNode == null)
                {
                    Form1 form = new Form1();
                    form.label4.Text = "Не выбраны точки отправления и прибытия.";
                    form.label4.Visible = true;
                    form.timer1.Stop();
                }

                _openList.Add(startNode);
                while (_openList.Count > 0)
                {
                    Node currentNode = GetLowestFCostNode(_openList);
                    _openList.Remove(currentNode);
                    _closedList.Add(currentNode);
                    if (currentNode == endNode)
                    {
                        return GetPath(endNode);
                    }
                    foreach (Node neighbor in GetNeighbors(currentNode))
                    {
                        if (neighbor != null && (neighbor.IsWall || _closedList.Contains(neighbor)))
                        {
                            continue;
                        }
                        int newGCost = currentNode.GCost + GetDistance(currentNode, neighbor, windX, windY);
                        if (newGCost < neighbor.GCost || !_openList.Contains(neighbor))
                        {
                            neighbor.GCost = newGCost;
                            neighbor.HCost = GetDistance(neighbor, endNode, windX, windY);
                            neighbor.Parent = currentNode;
                            if (!_openList.Contains(neighbor))
                            {
                                _openList.Add(neighbor);
                            }
                        }
                    }
                }
                return null;
            }
            // 
            private Node GetLowestFCostNode(List<Node> nodes)
            {
                Node lowestFCostNode = nodes[0];
                for (int i = 1; i < nodes.Count; i++)
                {
                    if (nodes[i].FCost < lowestFCostNode.FCost)
                    {
                        lowestFCostNode = nodes[i];
                    }
                }
                return lowestFCostNode;
            }

            // Ищем дистанцию от текущей клетки до конечной
            private int GetDistance(Node nodeA, Node nodeB, int windX, int windY)
            {
                int distanceX = Math.Abs(nodeA.X - nodeB.X);
                int distanceY = Math.Abs(nodeA.Y - nodeB.Y);
                int baseCost;

                if (distanceX > distanceY)
                {
                    baseCost = 14 * distanceY + 10 * (distanceX - distanceY);
                }
                else
                {
                    baseCost = 14 * distanceX + 10 * (distanceY - distanceX);
                }

                // Рассчитываем направление движения
                int moveX = nodeB.X - nodeA.X;
                int moveY = nodeB.Y - nodeA.Y;

                // Рассчитываем скалярное произведение направления движения и направления ветра
                int dotProduct = (moveX * windX) + (moveY * windY);

                // Нормируем векторы
                double moveLength = Math.Sqrt(moveX * moveX + moveY * moveY);
                double windLength = Math.Sqrt(windX * windX + windY * windY);

                double cosTheta = dotProduct / (moveLength * windLength);

                // Определяем коэффициент в зависимости от угла
                double windFactor;
                if (cosTheta > 0.5) // По ветру
                {
                    windFactor = 0.8; // Пример коэффициента, уменьшающего стоимость
                }
                else if (cosTheta < -0.5) // Против ветра
                {
                    windFactor = 1.2; // Пример коэффициента, увеличивающего стоимость
                }
                else
                {
                    windFactor = 1.0; // Ветер влияет нейтрально
                }

                // Применяем коэффициент влияния ветра
                double adjustedCost = baseCost * windFactor;
                return (int)adjustedCost;
            }
            private List<Node> GetPath(Node endNode)
            {
                List<Node> path = new List<Node>();
                Node currentNode = endNode;
                while (currentNode != null)
                {
                    path.Add(currentNode);
                    currentNode = currentNode.Parent;
                }
                path.Reverse();
                return path;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender,
        KeyPressEventArgs e) // обработчик для поля ввода осадки
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') // \b backspace
            {
                e.Handled = true;
            }
            else
            {
                int value;
                if (Int32.TryParse(textBox2.Text + e.KeyChar, out
                value)) // пытаемся преобразовать текст в число
                {
                    if (value < 0 || value > 24) // проверяем значений
                    {
                        if (e.KeyChar != '\b') // \b - backspace
                        {
                            e.Handled = true; // отменяем ввод символа
                        }
                    }
                }
                else
                {
                    if (e.KeyChar != '\b') // \b - backspace
                    {
                        e.Handled = true; // отменяем ввод символа
                    }
                }
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        // завершение редактирования поля ввода осадки
        {
            if (e.KeyCode == Keys.Enter)
            {
                string perem = textBox2.Text;
                osad = (double)(double.Parse(perem));
                label6.Text = perem;
                label6.Visible = true;
                textBox2.Visible = false;
                button2.Visible = true;
            }
        }

        private void pictureBox2_MouseDown(object sender,
        MouseEventArgs e) // установка точек начала и конца 
        {
            Bitmap bmp = (Bitmap)pictureBox2.Image;
            double scaleX = (double)((double)pictureBox2.Width / (double)pictureBox2.Image.Width);
            double scaleY = (double)((double)pictureBox2.Height / (double)pictureBox2.Image.Height);
            bmp.SetPixel((int)(e.X / scaleX), (int)(e.Y / scaleY), Color.Red);
            if (isFirstClick)
            {
                // устанавливаем первый объект
                X[(int)(e.X / scaleX), (int)(e.Y / scaleY)] = DOT_A;
                isFirstClick = false;
                ia = (int)(e.X / scaleX);
                ja = (int)(e.Y / scaleY);
            }
            else
            {
                // устанавливаем второй объект
                X[(int)(e.X / scaleX), (int)(e.Y / scaleY)] = DOT_B;
                isFirstClick = true;
                ib = (int)(e.X / scaleX);
                jb = (int)(e.Y / scaleY);
            }
            pictureBox2.Image = bmp;
        }
        private void button12_Click(object sender, EventArgs e)
        // нажатие кнопки открыть
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)| *.jpg; *.jpeg; *.png; *.gif | All files (*.*) | *.* ";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                Bitmap images = new Bitmap(selectedFileName);
                Color[,] Pix = new Color[images.Width, images.Height];
                X = new int[images.Width, images.Height];
                grid = new Node[images.Width, images.Height];
                nx = images.Width;
                ny = images.Height;
                bool isWall;
                count = new int[nx, ny];
                for (var i = 0; i < nx; i++)
                {
                    for (var j = 0; j < ny; j++)
                    {
                        Pix[i, j] = images.GetPixel(i, j);
                        if (Pix[i, j].R == 185)
                        {
                            X[i, j] = DIRT;
                            count[i, j] = 0;
                        }
                        if (Pix[i, j].R == 181)
                        {
                            X[i, j] = TREE;
                            count[i, j] = 0;
                        }
                        if (Pix[i, j].R == 239)
                        {
                            X[i, j] = SAND;
                            count[i, j] = 0;
                        }
                        if (Pix[i, j].R == 195)
                        {
                            X[i, j] = ROAD;
                            count[i, j] = 0;
                        }
                        if (Pix[i, j].R == 250)
                        {
                            X[i, j] = WATER_1_SAFE;
                            count[i, j] = 0;
                        }
                        if (Pix[i, j].R == 240)
                        {
                            X[i, j] = WATER_2_SAFE;
                            count[i, j] = 1;
                        }
                        if (Pix[i, j].R == 230)
                        {
                            X[i, j] = WATER_3_SAFE;
                            count[i, j] = 2;
                        }
                        if (Pix[i, j].R == 220)
                        {
                            X[i, j] = WATER_4_SAFE;
                            count[i, j] = 3;
                        }
                        if (Pix[i, j].R == 210)
                        {
                            X[i, j] = WATER_5_SAFE;
                            count[i, j] = 4;
                        }
                        if (Pix[i, j].R == 200)
                        {
                            X[i, j] = WATER_6_SAFE;
                            count[i, j] = 5;
                        }
                        if (Pix[i, j].R == 190)
                        {
                            X[i, j] = WATER_7_SAFE;
                            count[i, j] = 6;
                        }
                        if (Pix[i, j].R == 180)
                        {
                            X[i, j] = WATER_8_SAFE;
                            count[i, j] = 7;
                        }
                        if (Pix[i, j].R == 170)
                        {
                            X[i, j] = WATER_9_SAFE;
                            count[i, j] = 8;
                        }
                        if (Pix[i, j].R == 160)
                        {
                            X[i, j] = WATER_10_SAFE;
                            count[i, j] = 9;
                        }
                        if (Pix[i, j].R == 150)
                        {
                            X[i, j] = WATER_11_SAFE;
                            count[i, j] = 10;
                        }
                        if (Pix[i, j].R == 140)
                        {
                            X[i, j] = WATER_12_SAFE;
                            count[i, j] = 11;
                        }
                        if (Pix[i, j].R == 130)
                        {
                            X[i, j] = WATER_13_SAFE;
                            count[i, j] = 12;
                        }
                        if (Pix[i, j].R == 120)
                        {
                            X[i, j] = WATER_14_SAFE;
                            count[i, j] = 13;
                        }
                        if (Pix[i, j].R == 110)
                        {
                            X[i, j] = WATER_15_SAFE;
                            count[i, j] = 14;
                        }
                        if (Pix[i, j].R == 100)
                        {
                            X[i, j] = WATER_16_SAFE;
                            count[i, j] = 15;
                        }
                        if (Pix[i, j].R == 90)
                        {
                            X[i, j] = WATER_17_SAFE;
                            count[i, j] = 16;
                        }
                        if (Pix[i, j].R == 80)
                        {
                            X[i, j] = WATER_18_SAFE;
                            count[i, j] = 17;
                        }
                        if (Pix[i, j].R == 70)
                        {
                            X[i, j] = WATER_19_SAFE;
                            count[i, j] = 18;
                        }
                        if (Pix[i, j].R == 60)
                        {
                            X[i, j] = WATER_20_SAFE;
                            count[i, j] = 19;
                        }
                        if (Pix[i, j].R == 50)
                        {
                            X[i, j] = WATER_21_SAFE;
                            count[i, j] = 20;
                        }
                        if (Pix[i, j].R == 40)
                        {
                            X[i, j] = WATER_22_SAFE;
                            count[i, j] = 21;
                        }
                        if (Pix[i, j].R == 30)
                        {
                            X[i, j] = WATER_23_SAFE;
                            count[i, j] = 22;
                        }
                        if (Pix[i, j].R == 20)
                        {
                            X[i, j] = WATER_24_SAFE;
                            count[i, j] = 23;
                        }
                        if (Pix[i, j].R == 10)
                        {
                            X[i, j] = WATER_25_SAFE;
                            count[i, j] = 24;
                        }
                        if (Pix[i, j].R == 0)
                        {
                            X[i, j] = WATER_26_SAFE;
                            count[i, j] = 25;
                        }
                        if (Pix[i, j].R == 255)
                        {
                            X[i, j] = DOT_A;
                            count[i, j] = 25;
                        }
                        if (Pix[i, j].R == 254)
                        {
                            X[i, j] = DOT_B;
                            count[i, j] = 25;
                        }
                        if (Pix[i, j].G == 255)
                        {
                            X[i, j] = WAY;
                            count[i, j] = 25;
                        }
                    }
                }
                pictureBox2.Image = images;
                button2.Visible = false;
                label6.Visible = false;
                textBox2.Visible = true;
                textBox2.Text = string.Empty;
                label4.Visible = false;
                label4.Text = string.Empty;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            bool isWall;
            float price;
            int[,] X1 = new int[nx, ny];
            for (int ix = 0; ix < nx; ix++)
            {
                for (int iy = 0; iy < ny; iy++)
                {
                    if (X[ix, iy] == WATER_1_SAFE)
                    {
                        X1[ix, iy] = WATER_1_SAFE;
                    }
                    if (X[ix, iy] == WATER_2_SAFE)
                    {
                        X1[ix, iy] = WATER_2_SAFE;
                    }
                    if (X[ix, iy] == WATER_3_SAFE)
                    {
                        X1[ix, iy] = WATER_3_SAFE;
                    }
                    if (X[ix, iy] == WATER_4_SAFE)
                    {
                        X1[ix, iy] = WATER_4_SAFE;
                    }
                    if (X[ix, iy] == WATER_5_SAFE)
                    {
                        X1[ix, iy] = WATER_5_SAFE;
                    }
                    if (X[ix, iy] == WATER_6_SAFE)
                    {
                        X1[ix, iy] = WATER_6_SAFE;
                    }
                    if (X[ix, iy] == WATER_7_SAFE)
                    {
                        X1[ix, iy] = WATER_7_SAFE;
                    }
                    if (X[ix, iy] == WATER_8_SAFE)
                    {
                        X1[ix, iy] = WATER_8_SAFE;
                    }
                    if (X[ix, iy] == WATER_9_SAFE)
                    {
                        X1[ix, iy] = WATER_9_SAFE;
                    }
                    if (X[ix, iy] == WATER_10_SAFE)
                    {
                        X1[ix, iy] = WATER_10_SAFE;
                    }
                    if (X[ix, iy] == WATER_11_SAFE)
                    {
                        X1[ix, iy] = WATER_11_SAFE;
                    }
                    if (X[ix, iy] == WATER_12_SAFE)
                    {
                        X1[ix, iy] = WATER_12_SAFE;
                    }
                    if (X[ix, iy] == WATER_13_SAFE)
                    {
                        X1[ix, iy] = WATER_13_SAFE;
                    }
                    if (X[ix, iy] == WATER_14_SAFE)
                    {
                        X1[ix, iy] = WATER_14_SAFE;
                    }
                    if (X[ix, iy] == WATER_15_SAFE)
                    {
                        X1[ix, iy] = WATER_15_SAFE;
                    }
                    if (X[ix, iy] == WATER_16_SAFE)
                    {
                        X1[ix, iy] = WATER_16_SAFE;
                    }
                    if (X[ix, iy] == WATER_17_SAFE)
                    {
                        X1[ix, iy] = WATER_17_SAFE;
                    }
                    if (X[ix, iy] == WATER_18_SAFE)
                    {
                        X1[ix, iy] = WATER_18_SAFE;
                    }
                    if (X[ix, iy] == WATER_19_SAFE)
                    {
                        X1[ix, iy] = WATER_19_SAFE;
                    }
                    if (X[ix, iy] == WATER_20_SAFE)
                    {
                        X1[ix, iy] = WATER_20_SAFE;
                    }
                    if (X[ix, iy] == WATER_21_SAFE)
                    {
                        X1[ix, iy] = WATER_21_SAFE;
                    }
                    if (X[ix, iy] == WATER_22_SAFE)
                    {
                        X1[ix, iy] = WATER_22_SAFE;
                    }
                    if (X[ix, iy] == WATER_23_SAFE)
                    {
                        X1[ix, iy] = WATER_23_SAFE;
                    }
                    if (X[ix, iy] == WATER_24_SAFE)
                    {
                        X1[ix, iy] = WATER_24_SAFE;
                    }
                    if (X[ix, iy] == WATER_25_SAFE)
                    {
                        X1[ix, iy] = WATER_25_SAFE;
                    }
                    if (X[ix, iy] == WATER_26_SAFE)
                    {
                        X1[ix, iy] = WATER_26_SAFE;
                    }
                    if (X[ix, iy] == SAND)
                    {
                        X1[ix, iy] = SAND;
                    }
                    if (X[ix, iy] == ROAD)
                    {
                        X1[ix, iy] = ROAD;
                    }
                    if (X[ix, iy] == DIRT)
                    {
                        X1[ix, iy] = DIRT;
                    }
                    if (X[ix, iy] == TREE)
                    {
                        X1[ix, iy] = TREE;
                    }
                    if (X[ix, iy] == DOT_B)
                    {
                        X1[ix, iy] = DOT_B;
                    }
                    if (X[ix, iy] == WAY)
                    {
                        X1[ix, iy] = WAY;
                    }
                    if (X[ix, iy] == DOT_A)
                    {
                        X1[ix, iy] = DOT_A;
                    }

                }
            }
            for (int ix = 0; ix < nx; ix++)
            {
                for (int iy = 0; iy < ny; iy++)
                {
                    if (osad > count[ix, iy])
                    {
                        isWall = true;
                    }
                    else
                    {
                        isWall = false;
                        //price = f_base * (1 + Square * Speed * coefSpeed + HeightWave * coefWave * Periodicity);
                    }
                    grid[ix, iy] = new Node(ix, iy, isWall);
                }
            }
            AStar aStar = new AStar(grid);
            if (grid[grid[ib, jb].X - 1, grid[ib, jb].Y - 1].IsWall &&
                grid[grid[ib, jb].X, grid[ib, jb].Y - 1].IsWall &&
                grid[grid[ib, jb].X - 1, grid[ib, jb].Y].IsWall &&
                grid[grid[ib, jb].X + 1, grid[ib, jb].Y - 1].IsWall &&
                grid[grid[ib, jb].X + 1, grid[ib, jb].Y].IsWall &&
                grid[grid[ib, jb].X, grid[ib, jb].Y + 1].IsWall &&
                grid[grid[ib, jb].X + 1, grid[ib, jb].Y + 1].IsWall &&
                grid[grid[ib, jb].X - 1, grid[ib, jb].Y + 1].IsWall)
            {
                label4.Text = "Точка конца находится в недосягаемой зоне или не была выбрана";
                label4.Visible = true;
                timer1.Stop();
            }
            else
            {
                List<Node> path = aStar.FindPath(grid[ia, ja], grid[ib, jb], selectedWindDirection.x, selectedWindDirection.y);
                List<Node> neighbor = new List<Node>();
                if (grid[ib, jb].X > 0)
                {
                    neighbor.Add(grid[grid[ib, jb].X - 1, grid[ib, jb].Y]);
                }

                if (path != null)
                {
                    foreach (Node node in path)
                    {
                        X1[node.X, node.Y] = WAY;
                    }
                }
                else
                {
                    label4.Text = "Точка начала выбрана без учета осадки.Дальнейшее движение невозможно.Корабль намели.";
                    label4.Visible = true;
                    timer1.Stop();
                }
            }
            X = X1;
            Bitmap bitmap = new Bitmap(nx, ny);
            int count_way = 0;
            int count_b = 0;
            for (int i = 0; i < nx; i++)
            {
                for (int j = 0; j < ny; j++)
                {
                    if (X[i, j] == WAY)
                    {
                        count_way++;
                    }
                    if (X[i, j] == DOT_B)
                    {
                        count_b++;
                    }
                    bitmap.SetPixel(i, j, colorsList[X[i, j]]);
                }
            }
            if (count_b == 0 && count_way != 0)
            {
                timer1.Stop();
                button2.Visible = false;

            }
            pictureBox2.Image = bitmap;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Start();
            button2.Visible = !button2.Visible;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
