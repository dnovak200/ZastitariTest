# Design za zaštitare

## Upute za development

U folderu se nalazi file **database.sql** koji sadrži naredbe za kreiranje strukture tablica. 

Pozicionirati se preko komandne linije u folder gdje se nalazi file i napisati sljedeće naredbe:

1. Konekcija na bazu
```bash
sqlite3 database.db
```

2. Punjenje baze sa sadržajem iz file-a
```bash
.read database.sql
```

3. Provjera
```bash
select * from djelatnik;
```