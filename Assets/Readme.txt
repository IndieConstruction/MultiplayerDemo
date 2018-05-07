Multiplayer

Più computer connessi:
- Server
- Clients
- Ev. Server/Client

Si gioca la stessa sessione di gioco e vengono mandati aggiornamenti sullo stato del gioco.

SERVER AUTORITATIVO
Il server è responsabile dello stato del gioco. Tutti notificano al server i cambi di stato e il serve invia gli update a tutti i clients.
Nessun client può fare niente senza avere l'autorizzazione dal server.

NON AUTORITATIVO
Ogni client processa eventi e invia updates al server per sincronizzare gli altri client.

APPROCCIO IBRIDO (UNITY)
Il server è autoritativo per alcuni aspetti il client per altri.
- Player Authority -> il client ha controllo diretto sul proprio player e comunica ogni cambiamento che ha affettuato al rerver che lo comunica agli altri clients.
