namespace MyFortnite {
    class FNPlayer {
        public int ammo;
        public float health;

        public float Attack(FNPlayer enemy) {

            float damage = 10;
            enemy.TakeDamage(damage);
            return damage;
        }

        public void TakeDamage(float damage) {

            health -= damage;
        }

    }
}
