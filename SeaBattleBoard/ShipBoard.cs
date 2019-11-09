using  System.Linq;

namespace SeaBattleBoard {
    public class ShipBoard {
        private Board ships_;
        private Board shoots_;

        public void SetDefaultValues() {
            
        }

        public bool IsAnyShipAlive => this.shoots_.Count(s => s.HasValue && s.Value) < 20;

        public bool ValidateShips() {
            if (this.ships_.Count(s => s.HasValue && s.Value) != 20) return false;

        }
    }
}