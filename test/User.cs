using System;

namespace test {
    public class User : Battleship {
        public User() {
            Console.Write("Случайная расстановка кораблей? ");
            if (Console.ReadLine() == "да") {
                Console.Clear();
                this.Number = 0;
                this.Four();
                while (this.Number < three) {
                    this.Three();
                }
                this.Number = 0;
                while (this.Number < two) {
                    this.Two();
                }
                this.Number = 0;
                while (this.Number < one) {
                    this.One();
                }
            }
        }

        public void Strike() {
            if (this.Win()) {
                return;
            }
            Console.SetCursorPosition(30, Indent++);
            Console.WriteLine("Выстрел №: " + ++this.Step);
            var letter = true;
            while (letter) {
                Console.SetCursorPosition(30, Indent++);
                Console.Write("Ваш выстрел: ");
                switch (Console.Read()) {
                    case 'а':
                        this.Letter[this.Step] = 0;
                        letter = false;
                        break;
                    case 'б':
                        this.Letter[this.Step] = 1;
                        letter = false;
                        break;
                    case 'в':
                        this.Letter[this.Step] = 2;
                        letter = false;
                        break;
                    case 'г':
                        this.Letter[this.Step] = 3;
                        letter = false;
                        break;
                    case 'д':
                        this.Letter[this.Step] = 4;
                        letter = false;
                        break;
                    case 'е':
                        this.Letter[this.Step] = 5;
                        letter = false;
                        break;
                    case 'ж':
                        this.Letter[this.Step] = 6;
                        letter = false;
                        break;
                    case 'з':
                        this.Letter[this.Step] = 7;
                        letter = false;
                        break;
                    case 'и':
                        this.Letter[this.Step] = 8;
                        letter = false;
                        break;
                    case 'к':
                        this.Letter[this.Step] = 9;
                        letter = false;
                        break;
                }
            }
            this.Index[this.Step] = Convert.ToInt32(Console.ReadLine()) - 1;
            if (this.Hit(this.Index[this.Step], this.Letter[this.Step])) {
                this.Points++;
                this.Strike();
            }
        }

        public bool Hit(int i, int j) {
            if (BotField[i, j] == 0) {
                BotField[i, j] = 3;
                this.Field1[i, j] = 3;
                this.Output(this.Field1);
                Console.SetCursorPosition(30, 0);
                Console.Write("Промах!   ");
                return false;
            }
            if (BotField[i, j] == 1) {
                BotField[i, j] = 2;
                this.Field1[i, j] = 2;
                this.Stroke(BotField, i, j);
                this.Output(this.Field1);
                Console.SetCursorPosition(30, 0);
                Console.Write("Попадание!");
                return true;
            }
            Console.SetCursorPosition(30, 0);
            Console.Write("Нельзя стрелять в эту клетку");
            Console.SetCursorPosition(30, 4);
            Console.WriteLine();
            this.Step--;
            return true;
        }

        public bool Win() {
            if (this.Points == 20) {
                Console.SetCursorPosition(10, 0);
                Console.Write("Вы победили!");
                return true;
            }
            return false;
        }

        private void Four() {
            var random = new Random();
            var x = random.Next(10);
            var y = random.Next(10);
            if (x > 5) {
                y = random.Next(5);
                for (var i = y; i < y + 4; i++) {
                    UserField[i, x] = 1;
                }
                return;
            }
            if (y > 5) {
                x = random.Next(5);
                for (var j = x; j < x + 4; j++) {
                    UserField[y, j] = 1;
                }
                return;
            }
            var k = random.Next(1);
            if (k == 0) {
                for (var i = y; i < y + 4; i++) {
                    UserField[i, x] = 1;
                }
            }
            else {
                for (var j = x; j < x + 4; j++) {
                    UserField[y, j] = 1;
                }
            }
        }

        private void Three() {
            var random = new Random();
            var x = random.Next(10);
            var y = random.Next(10);
            if (y > 6) {
                x = random.Next(7);
                for (var i = y - 1; i < y + 2; i++) {
                    if (i < 0) {
                        i++;
                    }
                    if (i > 9) {
                        break;
                    }
                    for (var j = x - 1; j < x + 4; j++) {
                        if (j < 0) {
                            j++;
                        }
                        if (j > 9) {
                            break;
                        }
                        if (UserField[i, j] != 0) {
                            return;
                        }
                    }
                }
                for (var j = x; j < x + 3; j++) {
                    UserField[y, j] = 1;
                }
                this.Number++;
                return;
            }
            if (x > 6) {
                y = random.Next(7);
                for (var i = y - 1; i < y + 4; i++) {
                    if (i < 0) {
                        i++;
                    }
                    if (i > 9) {
                        break;
                    }
                    for (var j = x - 1; j < x + 2; j++) {
                        if (j < 0) {
                            j++;
                        }
                        if (j > 9) {
                            break;
                        }
                        {
                            if (UserField[i, j] != 0) {
                                return;
                            }
                        }
                    }
                }
                for (var i = y; i < y + 3; i++) {
                    UserField[i, x] = 1;
                }
                this.Number++;
                return;
            }
            var k = random.Next(1);
            if (k == 0) {
                for (var i = y - 1; i < y + 4; i++) {
                    if (i < 0) {
                        i++;
                    }
                    if (i > 9) {
                        break;
                    }
                    for (var j = x - 1; j < x + 2; j++) {
                        if (j < 0) {
                            j++;
                        }
                        if (j > 9) {
                            break;
                        }
                        if (UserField[i, j] != 0) {
                            return;
                        }
                    }
                }
                for (var i = y; i < y + 3; i++) {
                    UserField[i, x] = 1;
                }
                this.Number++;
            }
            else {
                for (var i = y - 1; i < y + 2; i++) {
                    if (i < 0) {
                        i++;
                    }
                    if (i > 9) {
                        break;
                    }
                    for (var j = x - 1; j < x + 4; j++) {
                        if (j < 0) {
                            j = 0;
                        }
                        if (j > 9) {
                            break;
                        }
                        if (UserField[i, j] != 0) {
                            return;
                        }
                    }
                }
                for (var j = x; j < x + 3; j++) {
                    UserField[y, j] = 1;
                }
                this.Number++;
            }
        }

        private void Two() {
            var random = new Random();
            var x = random.Next(10);
            var y = random.Next(10);
            if (y > 7) {
                x = random.Next(8);
                for (var i = y - 1; i < y + 2; i++) {
                    if (i < 0) {
                        i++;
                    }
                    if (i > 9) {
                        break;
                    }
                    for (var j = x - 1; j < x + 3; j++) {
                        if (j < 0) {
                            j++;
                        }
                        if (j > 9) {
                            break;
                        }
                        if (UserField[i, j] != 0) {
                            return;
                        }
                    }
                }
                for (var j = x; j < x + 2; j++) {
                    UserField[y, j] = 1;
                }
                this.Number++;
                return;
            }
            if (x > 7) {
                y = random.Next(8);
                for (var i = y - 1; i < y + 3; i++) {
                    if (i < 0) {
                        i++;
                    }
                    if (i > 9) {
                        break;
                    }
                    for (var j = x - 1; j < x + 2; j++) {
                        if (j < 0) {
                            j++;
                        }
                        if (j > 9) {
                            break;
                        }
                        if (UserField[i, j] != 0) {
                            return;
                        }
                    }
                }
                for (var i = y; i < y + 2; i++) {
                    UserField[i, x] = 1;
                }
                this.Number++;
                return;
            }
            var k = random.Next(1);
            if (k == 0) {
                for (var i = y - 1; i < y + 3; i++) {
                    if (i < 0) {
                        i++;
                    }
                    if (i > 9) {
                        break;
                    }
                    for (var j = x - 1; j < x + 2; j++) {
                        if (j < 0) {
                            j++;
                        }
                        if (j > 9) {
                            break;
                        }
                        if (UserField[i, j] != 0) {
                            return;
                        }
                    }
                }
                for (var i = y; i < y + 2; i++) {
                    UserField[i, x] = 1;
                }
                this.Number++;
            }
            else {
                for (var i = y - 1; i < y + 2; i++) {
                    if (i < 0) {
                        i++;
                    }
                    if (i > 9) {
                        break;
                    }
                    for (var j = x - 1; j < x + 3; j++) {
                        if (j < 0) {
                            j++;
                        }
                        if (j > 9) {
                            break;
                        }
                        if (UserField[i, j] != 0) {
                            return;
                        }
                    }
                }
                for (var j = x; j < x + 2; j++) {
                    UserField[y, j] = 1;
                }
                this.Number++;
            }
        }

        private void One() {
            var random = new Random();
            var x = random.Next(10);
            var y = random.Next(10);
            for (var i = y - 1; i < y + 2; i++) {
                if (i < 0) {
                    i++;
                }
                if (i > 9) {
                    break;
                }
                for (var j = x - 1; j < x + 2; j++) {
                    if (j < 0) {
                        j++;
                    }
                    if (j > 9) {
                        break;
                    }
                    if (UserField[i, j] != 0) {
                        return;
                    }
                }
            }
            UserField[y, x] = 1;
            this.Number++;
        }
    }
}