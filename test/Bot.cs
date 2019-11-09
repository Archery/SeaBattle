using System;

namespace test {
    public class Bot : Battleship {
        public Bot() {
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

        public void Strike() {
            if (this.Win()) {
                return;
            }
            this.Random();
            Console.SetCursorPosition(30, Indent++);
            Console.WriteLine("Выстрел противника: " + str1[this.Letter[this.Step]] + (this.Index[this.Step] + 1));
            if (this.Hit(this.Index[this.Step], this.Letter[this.Step])) {
                this.Step++;
                this.Points++;
                this.Strike();
            }
        }

        private void Random() {
            var random = new Random(DateTime.Now.Millisecond);
            this.Letter[this.Step] = random.Next(9);
            this.Index[this.Step] = random.Next(9);
            if (this.Field1[this.Index[this.Step], this.Letter[this.Step]] > 0) {
                this.Random();
            }
        }

        public bool Hit(int i, int j) {
            if (UserField[i, j] == 0) {
                this.Field1[i, j] = 3;
                UserField[i, j] = 3;
                return false;
            }
            if (UserField[i, j] == 1) {
                this.Field1[i, j] = 2;
                UserField[i, j] = 2;
                this.Stroke(UserField, i, j);
                return true;
            }
            if (UserField[i, j] > 1) {
                return false;
            }
            return false;
        }

        public bool Win() {
            if (this.Points == 20) {
                Console.SetCursorPosition(10, 0);
                Console.Write("Вы проиграли!");
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
                    BotField[i, x] = 1;
                }
                return;
            }
            if (y > 5) {
                x = random.Next(5);
                for (var j = x; j < x + 4; j++) {
                    BotField[y, j] = 1;
                }
                return;
            }
            var k = random.Next(1);
            if (k == 0) {
                for (var i = y; i < y + 4; i++) {
                    BotField[i, x] = 1;
                }
            }
            else {
                for (var j = x; j < x + 4; j++) {
                    BotField[y, j] = 1;
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
                        if (BotField[i, j] != 0) {
                            return;
                        }
                    }
                }
                for (var j = x; j < x + 3; j++) {
                    BotField[y, j] = 1;
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
                        if (BotField[i, j] != 0) {
                            return;
                        }
                    }
                }
                for (var i = y; i < y + 3; i++) {
                    BotField[i, x] = 1;
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
                        if (BotField[i, j] != 0) {
                            return;
                        }
                    }
                }
                for (var i = y; i < y + 3; i++) {
                    BotField[i, x] = 1;
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
                        if (BotField[i, j] != 0) {
                            return;
                        }
                    }
                }
                for (var j = x; j < x + 3; j++) {
                    BotField[y, j] = 1;
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
                        if (BotField[i, j] != 0) {
                            return;
                        }
                    }
                }
                for (var j = x; j < x + 2; j++) {
                    BotField[y, j] = 1;
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
                        if (j > 0) {
                            j++;
                        }
                        if (j > 9) {
                            break;
                        }
                        if (BotField[i, j] != 0) {
                            return;
                        }
                    }
                }
                for (var i = y; i < y + 2; i++) {
                    BotField[i, x] = 1;
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
                        if (BotField[i, j] != 0) {
                            return;
                        }
                    }
                }
                for (var i = y; i < y + 2; i++) {
                    BotField[i, x] = 1;
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
                        if (BotField[i, j] != 0) {
                            return;
                        }
                    }
                }
                for (var j = x; j < x + 2; j++) {
                    BotField[y, j] = 1;
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
                    if (BotField[i, j] != 0) {
                        return;
                    }
                }
            }
            BotField[y, x] = 1;
            this.Number++;
        }
    }
}