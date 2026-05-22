# MedAR-Virtual-Patient

A Virtual Reality (VR) application developed as part of the **Medical Augmented Reality** practical course. This project aims to bridge the gap between traditional medical simulation and immersive technology by simulating a highly interactive **Virtual Patient** into a physical space. 

The system leverages spatial computing to provide medical students, trainees, and practitioners with a risk-free environment to practice diagnostics, patient positioning, and anatomical visualization.

---

## Project Overview

In traditional medical training, practicing on physical manikins lacks dynamic physiological feedback, while training on real patients poses inherent safety risks. **MedAR-Virtual-Patient** introduces an immersive alternative using optical see-through Head-Mounted Displays (HMDs) like the Microsoft HoloLens 2 / Magic Leap or modern passthrough headsets (Meta Quest 2).

By anchoring a 3D virtual patient onto a physical environment (e.g., a real clinic bed or examination table), users can interact with complex physiological systems layer-by-layer, simulate clinical examinations, and view real-time holographic data overlays.

### Key Features
- **Precise Spatial Alignment:** Hand Tracking in VR to seamlessly interact with the virtual patient.
- **Interactive Patient Cases:** Simulates real-time clinical scenarios where the virtual patient exhibits visual symptoms (e.g., cyanosis, localized pain indicators) and responds to trainee interventions.
- **Multi-Modal Data Integration:** Displays holographic windows showing simulated vital signs (ECG, Heart Rate, SpO2) that react dynamically to the patient's condition.

---

## System Architecture & Tech Stack

The project is built using a modern spatial computing workflow optimized for performance and low-latency rendering in medical environments:

* **Game Engine:** Unity 3D
* **XR Framework:** Unity OpenXR Plugin
* **Tracking & Registration:** ARFoundation
* **Target Devices:** Meta Quest 2
* **Programming Language:** C#

---

## Project Demo Video

<p align="left">
  <a href="https://youtu.be/_miEvPi020A?si=UPG_b_S3IC5T7wrJ">
    <img src="https://img.youtube.com/vi/_miEvPi020A/maxresdefault.jpg" alt="MedAR Virtual Patient Demo" width="70%">
  </a>
</p>
