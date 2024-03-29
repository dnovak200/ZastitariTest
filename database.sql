CREATE TABLE IF NOT EXISTS djelatnik (
    djelatnik_id INTEGER PRIMARY KEY AUTOINCREMENT,
    sifra TEXT NOT NULL,
    ime TEXT NOT NULL,
    prezime TEXT NOT NULL,
    ugovor_aktivan INTEGER,
    CHECK (length(sifra) <= 6)
);