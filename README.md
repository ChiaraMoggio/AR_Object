# AR_Object

Applicazione AR sviluppata con Unity e AR Foundation.  
Permette di visualizzare un modello 3D (Audi scaricata da TurboSquid), trasformarlo e visualizzare tooltip informativi.

## Funzionalità
- Rilevamento dei piani tramite AR Foundation (ARCore).
- Posizionamento di un modello 3D con un tocco.
- UI per:
  - Spostare l'oggetto sul piano.
  - Ruotarlo.
  - Scalarlo.
  - Alzarlo o abbassarlo rispetto al piano.
- Tooltip visualizzabili in AR cliccando sui punti sensibili del modello:
  - Windows.
  - Knobs.
  - Bumper.
  - Lights.
  - Mirrors. 
## Ottimizzazione tramite LOD 
- Modello Audi organizzato in 3 livelli di dettaglio
  - LOD Group:
    - LOD 0: 100%
    - LOD 1: 60%
    - LOD 2: 30%
       
## Tecnologie utilizzate
- Unity 3D versione 2022.3.25f
- AR Foundation
- ARCore XR Plugin
- UI Canvas e Input Touch

## Struttura del progetto
- placeAudi: gestione posizionamento su piano.
- TransformationManager: gestione trasformazioni tramite pulsanti.
- TooltipController.cs: gestione visualizzazione tooltip.
- Prefab:
  - Audi_A7: modello 3D con 3 livelli di dettaglio.
  - AR Default Plane: visualizzazione dei piani.

