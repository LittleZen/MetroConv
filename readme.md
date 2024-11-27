<p align="center" style="font-size: 30px;">
 <b>Converx (v1.0.0.0)</b>
</p>

<p align="center" style="font-size: 15px;>
 <b style="font-style: italic;">Alpha - Demo Version</b>
</p>

<p align="center" style="font-size: 25px;>
A powerfull C# convertion tools
</p>

[DOWNLOAD](https://gitlab.we-com.local/j.mengarelli/converx/-/releases)
| [ISSUE](https://gitlab.we-com.local/j.mengarelli/converx/-/issues)
| [WIKI](http://google.com)

## Index

- [Presentazione Converx](#presentazione-api)
- [Usare Converx](#collegarsi-Converx)
- [Architettura e scelte di progetto](#architettura-e-scelte-di-progetto)
- [Servizi esterni utlizzati](#servizi-esterni-utlizzati)
- [Aggiunta di nuovi comuni](#about-Converx)
- [Licenza](#licenza)
- [Patch Note](#all-changes)

---

### Presentazione Converx

Converx è un tool scritto in .NET-Framework che implementa la possibilità di esportare tracciati in conformità con le direttive espresse da PA-Digitale (UrbiSmart).

Converx ha diverse utilità in fase di conversione:

> 1.  Storicizzazione pubblica delle query: ogni query viene salvata nella cartella di riferimento del comune, questo consente sia di tenere traccia dell'estrazione dati, sia di passare tranquillamente da comune a comune senza perdere dati o query. Altresì è possibile sfruttare git come sistema centrale di sincronizzazione delle query, cosicchè tutti abbiano traccia delle conversione altrui.

> 2.  Collegamento multiplo: Converx consente di gestire tutti i principali database, è possibile tramite la selezione SQL selezionare la tipologia di database a cui ci si sta connetendo. Ad oggi Converx supporta:<br><br> > _Mysql/MariaDB_ <br> > _Postgres_ <br> > _Oracle_ <br><br>\*_È possibile estendere la classe del connettore in qualsiasi momento per aggiungere nuovi tipo di connessione._

> 3.  Estrazione dati ottimizzata con funzioni: il sistema di estrazione record e di scrittura su disco è stato completamente scritto in C# nativo per ottimizzare la fase critica di estrazione dei dati.

> 4.  Aggiunta di tracciati in modalità semplice: è possibile in pochi passi implementare nuovi tracciati

> 5.  Programmazione: in caso di situazioni particolari, è sempre possibile ereditate le superclassi e lavorare direttamente in C# sul singolo caso, senza interferire con il normale funzionamento del programma

---

### Linee guida allo sviluppo

Sezione in costruzione...

---

### Architettura e scelte di progetto

100% C# 🟢💻

| Library          | Description                              |
| ---------------- | ---------------------------------------- |
| `.NET-Framework` | _v. 4.7.2_                               |
| `MetroUI`        | _Libreria grafica utilizzata per i form_ |

---

### Servizi esterni utilzzati

Di seguito alcune delle librerie utilizzate, si sottolinea altresì la possibilità di integrare git come source control e sistema di sincronizazzione delle query:

| Library                    | Description                                                   |
| -------------------------- | ------------------------------------------------------------- |
| `ini-parser`               | _Servizio utilizzato per salvare e gestire le configurazioni_ |
| `MySql.Data`               | _Libreria utilizzate per il collegamento Mysql/MariaDB_       |
| `Npgsql`                   | _Libreria utilizzate per il collegamento Postgres_            |
| `Oracle.ManagedDataAccess` | _Libreria utilizzate per il collegamento Oracle_              |

---

### About Converx

| About            | Description            |
| ---------------- | ---------------------- |
| `Developer`      | _Jacopo M. Mengarelli_ |
| `BASE VERSION`   | 1.0.0.0 - A            |
| `LATEST VERSION` | 1.0.0.0 - A            |

---

### Licenza

--

---

## All Changes:

WPI
