namespace MyFortnite {
    class FNPlayer {
        public int ammo;
        private float health;

        public float Attack(FNPlayer enemy) {
            float damage = 10;
            enemy.TakeDamage(damage);
            return damage;
        }

        public void TakeDamage(float damage) {
            health -= damage;
        }

        public FNPlayer() {
            ammo = 0;
            health = 100;
        }

        public FNPlayer(int ammo, float health) {
            this.ammo = ammo;
            SetHealth(health);
        }

        public float GetHealth() {
            return health;
        }

        public void SetHealth(float health) {
            if (health <= 100 && health > 0) {
                this.health = health;
            }
        }
    }
}
