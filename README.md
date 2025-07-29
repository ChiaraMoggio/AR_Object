# AR_Object

Applicazione AR sviluppata con Unity e AR Foundation.  
Permette di visualizzare un modello 3D (Audi A7), trasformarlo e visualizzare tooltip informativi.

## Funzionalità
- Rilevamento dei piani tramite AR Foundation (ARCore).
- Posizionamento di un modello 3D con un tocco.
- UI per:
  - Spostare l'oggetto sul piano.
  - Ruotarlo.
  - Scalarlo.
  - Alzarlo o abbassarlo rispetto al piano.
- Tooltip ìvisualizzabili in AR cliccando sui punti sensibili del modello:
  - Windows.
  - Knobs.
  - Bumper.
  - Lights.
  - Mirrors. 

## Tecnologie utilizzate
- Unity 3D
- AR Foundation
- ARCore XR Plugin
- UI Canvas e Input Touch

## Struttura del progetto
- placeAudi: gestione posizionamento su piano.
- TransformationManager: gestione trasformazioni tramite pulsanti.
- TooltipController.cs: gestione visualizzazione tooltip.
- Prefab:
  - Audi_A7: modello 3D.
  - AR Default Plane: visualizzazione dei piani.

