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
            WATER_1_DANGER = 33, WATER_2_DANGER = 34,
            WATER_3_DANGER = 35, WATER_4_DANGER = 36, WATER_5_DANGER = 37,
            WATER_6_DANGER = 38, WATER_7_DANGER = 39, WATER_8_DANGER = 40,
            WATER_9_DANGER = 41, WATER_10_DANGER = 42, WATER_11_DANGER = 43,
            WATER_12_DANGER = 44, WATER_13_DANGER = 45, WATER_14_DANGER = 46,
            WATER_15_DANGER = 47, WATER_16_DANGER = 48, WATER_17_DANGER = 49,
            WATER_18_DANGER = 50, WATER_19_DANGER = 51, WATER_20_DANGER = 52,
            WATER_21_DANGER = 53, WATER_22_DANGER = 54, WATER_23_DANGER = 55,
            WATER_24_DANGER = 56, WATER_25_DANGER = 57, WATER_26_DANGER = 58,

            // Водные объекты разной глубины с опасными погодными условиями 
            WATER_1_NORMAL = 59, WATER_2_NORMAL = 60,
            WATER_3_NORMAL = 61, WATER_4_NORMAL = 62, WATER_5_NORMAL = 63,
            WATER_6_NORMAL = 64, WATER_7_NORMAL = 65, WATER_8_NORMAL = 66,
            WATER_9_NORMAL = 67, WATER_10_NORMAL = 68, WATER_11_NORMAL = 69,
            WATER_12_NORMAL = 70, WATER_13_NORMAL = 71, WATER_14_NORMAL = 72,
            WATER_15_NORMAL = 73, WATER_16_NORMAL = 74, WATER_17_NORMAL = 75,
            WATER_18_NORMAL = 76, WATER_19_NORMAL = 77, WATER_20_NORMAL = 78,
            WATER_21_NORMAL = 79, WATER_22_NORMAL = 80, WATER_23_NORMAL = 81,
            WATER_24_NORMAL = 82, WATER_25_NORMAL = 83, WATER_26_NORMAL = 84;

        private readonly Color[] colorsList = //цвета объектов в RGB
        {
            // Цвета объектов природы не используещихся для движения
            Color.FromArgb(185, 122, 87), Color.FromArgb(181, 230 ,29), Color.FromArgb(197, 173, 104), Color.FromArgb(195, 195, 195),
            // Цвета точек начала, конца, путь
            Color.FromArgb(2, 0, 254), Color.FromArgb(3, 0, 253), Color.FromArgb(1, 0, 255),
            
            // Цвета водных объектов разной глубины с безопасными погодными условиями
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
            Color.FromArgb(10, 255, 10),   Color.FromArgb(0, 255, 0),

            // Цвета водных объектов разной глубины с опасными погодными условиями
            Color.FromArgb(255, 250, 250), Color.FromArgb(254, 240, 240),
            Color.FromArgb(253, 230, 230), Color.FromArgb(252, 220, 220),
            Color.FromArgb(251, 210, 210), Color.FromArgb(249, 200, 200),
            Color.FromArgb(248, 190, 190), Color.FromArgb(247, 180, 180),
            Color.FromArgb(246, 170, 170), Color.FromArgb(245, 160, 160),
            Color.FromArgb(244, 150, 150), Color.FromArgb(243, 140, 140),
            Color.FromArgb(242, 130, 130), Color.FromArgb(241, 120, 120),
            Color.FromArgb(239, 110, 110), Color.FromArgb(238, 100, 100),
            Color.FromArgb(237, 90, 90),   Color.FromArgb(236, 80, 80),
            Color.FromArgb(235, 70, 70),   Color.FromArgb(234, 60, 60),
            Color.FromArgb(233, 50, 50),   Color.FromArgb(232, 40, 40),
            Color.FromArgb(231, 30, 30),   Color.FromArgb(229, 20, 20),
            Color.FromArgb(228, 10, 10),   Color.FromArgb(227, 0, 0),

            // Цвета водных объектов разной глубины с погодными условиями средней опасности
            Color.FromArgb(226, 255, 250), Color.FromArgb(225, 255, 240),
            Color.FromArgb(224, 255, 230), Color.FromArgb(223, 255, 220),
            Color.FromArgb(222, 255, 210), Color.FromArgb(221, 255, 200),
            Color.FromArgb(219, 255, 190), Color.FromArgb(218, 255, 180),
            Color.FromArgb(217, 255, 170), Color.FromArgb(216, 255, 160),
            Color.FromArgb(215, 255, 150), Color.FromArgb(214, 255, 140),
            Color.FromArgb(213, 255, 130), Color.FromArgb(212, 255, 120),
            Color.FromArgb(211, 255, 110), Color.FromArgb(209, 255, 100),
            Color.FromArgb(208, 255, 90),  Color.FromArgb(207, 255, 80),
            Color.FromArgb(206, 255, 70),  Color.FromArgb(205, 255, 60),
            Color.FromArgb(204, 255, 50),  Color.FromArgb(203, 255, 40),
            Color.FromArgb(202, 255, 30),  Color.FromArgb(201, 255, 20),
            Color.FromArgb(199, 255, 10),  Color.FromArgb(198, 255, 0)
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
        private int[,] zone; // 0 - нет зоны, 1 -  безопасная, 2 - нормальная, 3 - опасная
        private Node[,] grid;
        private double osad = 3;
        private bool isFirstClick = true;
        private double safe_wind = 1;
        private double normal_wind = 1;
        private double danger_wind = 1;
        private double height = 1;
        private double width = 1;
        private double length = 1;
        private double square = 1;

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

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e, TextBox textBox)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') // \b backspace
            {
                e.Handled = true;
            }
            else
            {
                int value;
                if (Int32.TryParse(textBox.Text + e.KeyChar, out value)) // пытаемся преобразовать текст в число
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

        private void TextBox_KeyDown(object sender, KeyEventArgs e, TextBox textBox, ref double windValue, Label label, Button button)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string perem = textBox.Text;
                windValue = double.Parse(perem);
                label.Text = perem;
                label.Visible = true;
                textBox.Visible = false;
                button.Visible = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) // обработчик для поля ввода осадки
        {
            TextBox_KeyPress(sender, e, input_osad);
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e) // завершение редактирования поля ввода осадки
        {
            TextBox_KeyDown(sender, e, input_osad, ref osad, label_osad, button2);
        }

        private void safeWind_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e, safeWind);
        }

        private void safeWind_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox_KeyDown(sender, e, safeWind, ref safe_wind, label_safe, button2);
        }

        private void normalWind_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e, normalWind);
        }

        private void normalWind_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox_KeyDown(sender, e, normalWind, ref normal_wind, label_normal, button2);
        }

        private void dangerWind_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e, dangerWind);
        }

        private void dangerWind_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox_KeyDown(sender, e, dangerWind, ref danger_wind, label_danger, button2);
        }

        private void length_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e, input_length);
        }

        private void length_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox_KeyDown(sender, e, input_length, ref length, label_length, button2);
        }

        private void width_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e, input_width);
        }

        private void width_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox_KeyDown(sender, e, input_width, ref width, label_width, button2);
        }

        private void height_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e, input_height);
        }

        private void height_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox_KeyDown(sender, e, input_height, ref height, label_height, button2);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e) // установка точек начала и конца 
        {
            Bitmap bmp = (Bitmap)pictureBox2.Image;
            double scaleX = (double)((double)pictureBox2.Width / (double)pictureBox2.Image.Width);
            double scaleY = (double)((double)pictureBox2.Height / (double)pictureBox2.Image.Height);
            bmp.SetPixel((int)(e.X / scaleX), (int)(e.Y / scaleY), Color.Blue);
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
        private void button12_Click(object sender, EventArgs e) // нажатие кнопки открыть
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
                zone = new int[nx, ny];
                for (var i = 0; i < nx; i++)
                {
                    for (var j = 0; j < ny; j++)
                    {
                        Pix[i, j] = images.GetPixel(i, j);
                        switch (Pix[i, j].R)
                        {
                            case 185:
                                X[i, j] = DIRT;
                                count[i, j] = 0;
                                zone[i, j] = 0;
                                break;
                            case 181: 
                                X[i, j] = TREE;
                                count[i, j] = 0;
                                zone[i, j] = 0;
                                break;
                            case 197: 
                                X[i, j] = SAND;
                                count[i, j] = 0;
                                zone[i, j] = 0;
                                break;
                            case 195: 
                                X[i, j] = ROAD;
                                count[i, j] = 0;
                                zone[i, j] = 0;
                                break;
                            case 250: 
                                X[i, j] = WATER_1_SAFE;
                                count[i, j] = 0;
                                zone[i, j] = 1;
                                break;
                            case 240: 
                                X[i, j] = WATER_2_SAFE;
                                count[i, j] = 1;
                                zone[i, j] = 1;
                                break;
                            case 230:
                                X[i, j] = WATER_3_SAFE;
                                count[i, j] = 2;
                                zone[i, j] = 1;
                                break;
                            case 220:
                                X[i, j] = WATER_4_SAFE;
                                count[i, j] = 3;
                                zone[i, j] = 1;
                                break;
                            case 210:
                                X[i, j] = WATER_5_SAFE;
                                count[i, j] = 4;
                                zone[i, j] = 1;
                                break;
                            case 200:
                                X[i, j] = WATER_6_SAFE;
                                count[i, j] = 5;
                                zone[i, j] = 1;
                                break;
                            case 190:
                                X[i, j] = WATER_7_SAFE;
                                count[i, j] = 6;
                                zone[i, j] = 1;
                                break;
                            case 180:
                                X[i, j] = WATER_8_SAFE;
                                count[i, j] = 7;
                                zone[i, j] = 1;
                                break;
                            case 170:
                                X[i, j] = WATER_9_SAFE;
                                count[i, j] = 8;
                                zone[i, j] = 1;
                                break;
                            case 160:
                                X[i, j] = WATER_10_SAFE;
                                count[i, j] = 9;
                                zone[i, j] = 1;
                                break;
                            case 150:
                                X[i, j] = WATER_11_SAFE;
                                count[i, j] = 10;
                                zone[i, j] = 1;
                                break;
                            case 140:
                                X[i, j] = WATER_12_SAFE;
                                count[i, j] = 11;
                                zone[i, j] = 1;
                                break;
                            case 130:
                                X[i, j] = WATER_13_SAFE;
                                count[i, j] = 12;
                                zone[i, j] = 1;
                                break;
                            case 120:
                                X[i, j] = WATER_14_SAFE;
                                count[i, j] = 13;
                                zone[i, j] = 1;
                                break;
                            case 110:
                                X[i, j] = WATER_15_SAFE;
                                count[i, j] = 14;
                                zone[i, j] = 1;
                                break;
                            case 100:
                                X[i, j] = WATER_16_SAFE;
                                count[i, j] = 15;
                                zone[i, j] = 1;
                                break;
                            case 90:
                                X[i, j] = WATER_17_SAFE;
                                count[i, j] = 16;
                                zone[i, j] = 1;
                                break;
                            case 80:
                                X[i, j] = WATER_18_SAFE;
                                count[i, j] = 17;
                                zone[i, j] = 1;
                                break;
                            case 70:
                                X[i, j] = WATER_19_SAFE;
                                count[i, j] = 18;
                                zone[i, j] = 1;
                                break;
                            case 60:
                                X[i, j] = WATER_20_SAFE;
                                count[i, j] = 19;
                                zone[i, j] = 1;
                                break;
                            case 50:
                                X[i, j] = WATER_21_SAFE;
                                count[i, j] = 20;
                                zone[i, j] = 1;
                                break;
                            case 40:
                                X[i, j] = WATER_22_SAFE;
                                count[i, j] = 21;
                                zone[i, j] = 1;
                                break;
                            case 30:
                                X[i, j] = WATER_23_SAFE;
                                count[i, j] = 22;
                                zone[i, j] = 1;
                                break;
                            case 20:
                                X[i, j] = WATER_24_SAFE;
                                count[i, j] = 23;
                                zone[i, j] = 1;
                                break;
                            case 10:
                                X[i, j] = WATER_25_SAFE;
                                count[i, j] = 24;
                                zone[i, j] = 1;
                                break;
                            case 0:
                                X[i, j] = WATER_26_SAFE;
                                count[i, j] = 25;
                                zone[i, j] = 1;
                                break;
                            case 2:
                                X[i, j] = DOT_A;
                                count[i, j] = 25;
                                break;
                            case 3:
                                X[i, j] = DOT_B;
                                count[i, j] = 25;
                                break;
                            case 1:
                                X[i, j] = WAY;
                                count[i, j] = 25;
                                break;
                            case 226:
                                X[i, j] = WATER_1_NORMAL;
                                count[i, j] = 0;
                                zone[i, j] = 2;
                                break;
                            case 225:
                                X[i, j] = WATER_2_NORMAL;
                                count[i, j] = 1;
                                zone[i, j] = 2;
                                break;
                            case 224:
                                X[i, j] = WATER_3_NORMAL;
                                count[i, j] = 2;
                                zone[i, j] = 2;
                                break;
                            case 223:
                                X[i, j] = WATER_4_NORMAL;
                                count[i, j] = 3;
                                zone[i, j] = 2;
                                break;
                            case 222:
                                X[i, j] = WATER_5_NORMAL;
                                count[i, j] = 4;
                                zone[i, j] = 2;
                                break;
                            case 221:
                                X[i, j] = WATER_6_NORMAL;
                                count[i, j] = 5;
                                zone[i, j] = 2;
                                break;
                            case 219:
                                X[i, j] = WATER_7_NORMAL;
                                count[i, j] = 6;
                                zone[i, j] = 2;
                                break;
                            case 218:
                                X[i, j] = WATER_8_NORMAL;
                                count[i, j] = 7;
                                zone[i, j] = 2;
                                break;
                            case 217:
                                X[i, j] = WATER_9_NORMAL;
                                count[i, j] = 8;
                                zone[i, j] = 2;
                                break;
                            case 216:
                                X[i, j] = WATER_10_NORMAL;
                                count[i, j] = 9;
                                zone[i, j] = 2;
                                break;
                            case 215:
                                X[i, j] = WATER_11_NORMAL;
                                count[i, j] = 10;
                                zone[i, j] = 2;
                                break;
                            case 214:
                                X[i, j] = WATER_12_NORMAL;
                                count[i, j] = 11;
                                zone[i, j] = 2;
                                break;
                            case 213:
                                X[i, j] = WATER_13_NORMAL;
                                count[i, j] = 12;
                                zone[i, j] = 2;
                                break;
                            case 212:
                                X[i, j] = WATER_14_NORMAL;
                                count[i, j] = 13;
                                zone[i, j] = 2;
                                break;
                            case 211:
                                X[i, j] = WATER_15_NORMAL;
                                count[i, j] = 14;
                                zone[i, j] = 2;
                                break;
                            case 209:
                                X[i, j] = WATER_16_NORMAL;
                                count[i, j] = 15;
                                zone[i, j] = 2;
                                break;
                            case 208:
                                X[i, j] = WATER_17_NORMAL;
                                count[i, j] = 16;
                                zone[i, j] = 2;
                                break;
                            case 207:
                                X[i, j] = WATER_18_NORMAL;
                                count[i, j] = 17;
                                zone[i, j] = 2;
                                break;
                            case 206:
                                X[i, j] = WATER_19_NORMAL;
                                count[i, j] = 18;
                                zone[i, j] = 2;
                                break;
                            case 205:
                                X[i, j] = WATER_20_NORMAL;
                                count[i, j] = 19;
                                zone[i, j] = 2;
                                break;
                            case 204:
                                X[i, j] = WATER_21_NORMAL;
                                count[i, j] = 20;
                                zone[i, j] = 2;
                                break;
                            case 203:
                                X[i, j] = WATER_22_NORMAL;
                                count[i, j] = 21;
                                zone[i, j] = 2;
                                break;
                            case 202:
                                X[i, j] = WATER_23_NORMAL;
                                count[i, j] = 22;
                                zone[i, j] = 2;
                                break;
                            case 201:
                                X[i, j] = WATER_24_NORMAL;
                                count[i, j] = 23;
                                zone[i, j] = 2;
                                break;
                            case 199:
                                X[i, j] = WATER_25_NORMAL;
                                count[i, j] = 24;
                                zone[i, j] = 2;
                                break;
                            case 198:
                                X[i, j] = WATER_26_NORMAL;
                                count[i, j] = 25;
                                zone[i, j] = 2;
                                break;
                            case 255:
                                X[i, j] = WATER_1_DANGER;
                                count[i, j] = 0;
                                zone[i, j] = 3;
                                break;
                            case 254:
                                X[i, j] = WATER_2_DANGER;
                                count[i, j] = 1;
                                zone[i, j] = 3;
                                break;
                            case 253:
                                X[i, j] = WATER_3_DANGER;
                                count[i, j] = 2;
                                zone[i, j] = 3;
                                break;
                            case 252:
                                X[i, j] = WATER_4_DANGER;
                                count[i, j] = 3;
                                zone[i, j] = 3;
                                break;
                            case 251:
                                X[i, j] = WATER_5_DANGER;
                                count[i, j] = 4;
                                zone[i, j] = 3;
                                break;
                            case 249:
                                X[i, j] = WATER_6_DANGER;
                                count[i, j] = 5;
                                zone[i, j] = 3;
                                break;
                            case 248:
                                X[i, j] = WATER_7_DANGER;
                                count[i, j] = 6;
                                zone[i, j] = 3;
                                break;
                            case 247:
                                X[i, j] = WATER_8_DANGER;
                                count[i, j] = 7;
                                zone[i, j] = 3;
                                break;
                            case 246:
                                X[i, j] = WATER_9_DANGER;
                                count[i, j] = 8;
                                zone[i, j] = 3;
                                break;
                            case 245:
                                X[i, j] = WATER_10_DANGER;
                                count[i, j] = 9;
                                zone[i, j] = 3;
                                break;
                            case 244:
                                X[i, j] = WATER_11_DANGER;
                                count[i, j] = 10;
                                zone[i, j] = 3;
                                break;
                            case 243:
                                X[i, j] = WATER_12_DANGER;
                                count[i, j] = 11;
                                zone[i, j] = 3;
                                break;
                            case 242:
                                X[i, j] = WATER_13_DANGER;
                                count[i, j] = 12;
                                zone[i, j] = 3;
                                break;
                            case 241:
                                X[i, j] = WATER_14_DANGER;
                                count[i, j] = 13;
                                zone[i, j] = 3;
                                break;
                            case 239:
                                X[i, j] = WATER_15_DANGER;
                                count[i, j] = 14;
                                zone[i, j] = 3;
                                break;
                            case 238:
                                X[i, j] = WATER_16_DANGER;
                                count[i, j] = 15;
                                zone[i, j] = 3;
                                break;
                            case 237:
                                X[i, j] = WATER_17_DANGER;
                                count[i, j] = 16;
                                zone[i, j] = 3;
                                break;
                            case 236:
                                X[i, j] = WATER_18_DANGER;
                                count[i, j] = 17;
                                zone[i, j] = 3;
                                break;
                            case 235:
                                X[i, j] = WATER_19_DANGER;
                                count[i, j] = 18;
                                zone[i, j] = 3;
                                break;
                            case 234:
                                X[i, j] = WATER_20_DANGER;
                                count[i, j] = 19;
                                zone[i, j] = 3;
                                break;
                            case 233:
                                X[i, j] = WATER_21_DANGER;
                                count[i, j] = 20;
                                zone[i, j] = 3;
                                break;
                            case 232:
                                X[i, j] = WATER_22_DANGER;
                                count[i, j] = 21;
                                zone[i, j] = 3;
                                break;
                            case 231:
                                X[i, j] = WATER_23_DANGER;
                                count[i, j] = 22;
                                zone[i, j] = 3;
                                break;
                            case 229:
                                X[i, j] = WATER_24_DANGER;
                                count[i, j] = 23;
                                zone[i, j] = 3;
                                break;
                            case 228:
                                X[i, j] = WATER_25_DANGER;
                                count[i, j] = 24;
                                zone[i, j] = 3;
                                break;
                            case 227:
                                X[i, j] = WATER_26_DANGER;
                                count[i, j] = 25;
                                zone[i, j] = 3;
                                break;
                            default:
                                break;
                        }

                    }
                }
                pictureBox2.Image = images;
                button2.Visible = false;
                label_osad.Visible = false;
                label_safe.Visible = false;
                label_normal.Visible = false;
                label_danger.Visible = false;   
                label_height.Visible = false;
                label_width.Visible = false;
                label_length.Visible = false;
                input_osad.Visible = true;
                input_osad.Text = string.Empty;
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
                    switch (X[ix, iy])
                    {
                        // Водные объекты с безопасными погодными условиями
                        case WATER_1_SAFE:
                        case WATER_2_SAFE:
                        case WATER_3_SAFE:
                        case WATER_4_SAFE:
                        case WATER_5_SAFE:
                        case WATER_6_SAFE:
                        case WATER_7_SAFE:
                        case WATER_8_SAFE:
                        case WATER_9_SAFE:
                        case WATER_10_SAFE:
                        case WATER_11_SAFE:
                        case WATER_12_SAFE:
                        case WATER_13_SAFE:
                        case WATER_14_SAFE:
                        case WATER_15_SAFE:
                        case WATER_16_SAFE:
                        case WATER_17_SAFE:
                        case WATER_18_SAFE:
                        case WATER_19_SAFE:
                        case WATER_20_SAFE:
                        case WATER_21_SAFE:
                        case WATER_22_SAFE:
                        case WATER_23_SAFE:
                        case WATER_24_SAFE:
                        case WATER_25_SAFE:
                        case WATER_26_SAFE:
                            X1[ix, iy] = X[ix, iy];
                            break;

                        // Водные объекты с погодными условиями средней опасности
                        case WATER_1_NORMAL:
                        case WATER_2_NORMAL:
                        case WATER_3_NORMAL:
                        case WATER_4_NORMAL:
                        case WATER_5_NORMAL:
                        case WATER_6_NORMAL:
                        case WATER_7_NORMAL:
                        case WATER_8_NORMAL:
                        case WATER_9_NORMAL:
                        case WATER_10_NORMAL:
                        case WATER_11_NORMAL:
                        case WATER_12_NORMAL:
                        case WATER_13_NORMAL:
                        case WATER_14_NORMAL:
                        case WATER_15_NORMAL:
                        case WATER_16_NORMAL:
                        case WATER_17_NORMAL:
                        case WATER_18_NORMAL:
                        case WATER_19_NORMAL:
                        case WATER_20_NORMAL:
                        case WATER_21_NORMAL:
                        case WATER_22_NORMAL:
                        case WATER_23_NORMAL:
                        case WATER_24_NORMAL:
                        case WATER_25_NORMAL:
                        case WATER_26_NORMAL:
                            X1[ix, iy] = X[ix, iy];
                            break;

                        // Водные объекты с опасными погодными условиями
                        case WATER_1_DANGER:
                        case WATER_2_DANGER:
                        case WATER_3_DANGER:
                        case WATER_4_DANGER:
                        case WATER_5_DANGER:
                        case WATER_6_DANGER:
                        case WATER_7_DANGER:
                        case WATER_8_DANGER:
                        case WATER_9_DANGER:
                        case WATER_10_DANGER:
                        case WATER_11_DANGER:
                        case WATER_12_DANGER:
                        case WATER_13_DANGER:
                        case WATER_14_DANGER:
                        case WATER_15_DANGER:
                        case WATER_16_DANGER:
                        case WATER_17_DANGER:
                        case WATER_18_DANGER:
                        case WATER_19_DANGER:
                        case WATER_20_DANGER:
                        case WATER_21_DANGER:
                        case WATER_22_DANGER:
                        case WATER_23_DANGER:
                        case WATER_24_DANGER:
                        case WATER_25_DANGER:
                        case WATER_26_DANGER:
                            X1[ix, iy] = X[ix, iy];
                            break;

                        // Другие объекты природы и пути
                        case SAND:
                        case ROAD:
                        case DIRT:
                        case TREE:
                        case DOT_B:
                        case WAY:
                        case DOT_A:
                            X1[ix, iy] = X[ix, iy];
                            break;

                        default:
                            // Обработка случаев, если не совпадает ни с одним из перечисленных значений
                            break;
                    }

                }
            }
            double speed;
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
                        switch (zone[ix, iy])
                        {
                            case 1:
                                speed = safe_wind;
                                break;
                            case 2:
                                speed = normal_wind;
                                break;
                            case 3:
                                speed = danger_wind;
                                break;
                            default:
                                speed = 0;
                                break;
                        }
                    }
                    //price = f_base * (1 + square * speed * 0.0005); //+ heightWave * coefWave * periodicity);
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
