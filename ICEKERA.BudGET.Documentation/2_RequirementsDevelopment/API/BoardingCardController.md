---
title: Supposed output of the trip sorter
description: Supposed output of BoardingCardController API methods
author: BLVCK971
ms.date: 04/11/2024 
---
# Trip Sorter
## Input data
```json
[
{"departure": "Stockholm", "arrival": "New York", "transport": "Flight", "transportNumber": "SK22", "seat": "7B", "gate": "22" },
{"departure": "Barcelona", "arrival": "Gerona Airport", "transport": "Airport Bus" },
{"departure": "Madrid", "arrival": "Barcelona", "transport": "Train", "transportNumber": "78A", "seat": "45B" },
{"departure": "Gerona Airport", "arrival": "Stockholm", "transport": "Flight", "transportNumber": "SK455", "seat": "3A", "gate": "45B", "baggage": "344" }
]
```

## Supposed output of the trip sorter
### Expected output 1 : Sorted data
```json
[
{"departure": "Madrid", "arrival": "Barcelona", "transport": "Train", "transportNumber": "78A", "seat": "45B" },
{"departure": "Barcelona", "arrival": "Gerona Airport", "transport": "Airport Bus" },
{"departure": "Gerona Airport", "arrival": "Stockholm", "transport": "Flight", "transportNumber": "SK455", "seat": "3A", "gate": "45B", "baggage": "344" },
{"departure": "Stockholm", "arrival": "New York", "transport": "Flight", "transportNumber": "SK22", "seat": "7B", "gate": "22" }
]
```
### Expected output 2 : Sentences
```json
[
"Take train 78A from Madrid to Barcelona. Sit in seat 45B.",
"Take the airport bus from Barcelona to Gerona Airport. No seat assignment.",
"From Gerona Airport, take flight SK455 to Stockholm. Gate 45B, seat 3A. Baggage drop at ticket counter 344.",
"From Stockholm, take flight SK22 to New York. Gate 22, seat 7B. Baggage will be automatically transferred from your last leg.",
"You have arrived at your final destination."
]
```

>[!div class="step-by-step"]
> [Pre](../Requirements/TechnicalTest.md)