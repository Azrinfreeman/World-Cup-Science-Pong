# World Cup Science Pong

A Unity science-learning prototype that combines a football-themed Pong match with Malay multiple-choice questions. Goal celebrations lead into question prompts, while player profiles, country flags, scores, and trophies support the surrounding learning-game presentation.

## Features in the reviewed source

- Paddle/ball matches with AI-opponent and human-opponent paths.
- Goal-state integration that selects the appropriate player's question panel.
- Science question banks including body parts and senses, with randomized questions and answer placement.
- A reviewed correct-answer reward of five stars through the collection system.
- Local player profiles, scores, trophy values, and flag selection.

These are source-based descriptions, not a verified gameplay release. Scene wiring, content accuracy, input behavior, and device builds were not tested during this review.

## Open the project

1. Install **Unity 2022.3.60f1**, matching [ProjectVersion.txt](ProjectSettings/ProjectVersion.txt), and clone the repository with its required assets.
2. Add the repository root through Unity Hub and allow package resolution and asset import to finish.
3. Open `Assets/Pong/Scenes/GamePlay.unity`. Inspect backend requests before entering Play mode with player data; use synthetic profiles for development checks.
4. Exercise AI and human-opponent match paths, level selection, goals, question answers, and the return to kickoff.

The [manifest](Packages/manifest.json) includes URP 14.0.12, TextMesh Pro 3.0.7, Unity UI 1.0.0, and the 2D feature package. EditorBuildSettings is stored in Unity binary serialization; its embedded GamePlay scene path was inspected, but enabled scene flags/order were not fully deserialized. Confirm build settings in the Editor before building.

## Code guide

| Area | Source |
| --- | --- |
| Science question content | [QuestionClasses](Assets/QuestionClasses.cs) |
| Level/question-list selection | [QuestionController](Assets/QuestionController.cs) |
| Player question UI and answer rewards | [GameController](Assets/GameController.cs) |
| Match collection totals | [CollectionController](Assets/CollectionController.cs) |
| Profile setup and reporting | [GameStartupController](Assets/GameStartupController.cs) |

Pong gameplay and state transitions live under `Assets/Pong/Scripts/`, including GoalState and MatchManager. Keep their existing attribution when extending the adaptation.

## Data, networking, and release status

PlayerPrefs stores local profiles and score/trophy values; match/player totals use multiple key schemes, so persistent profile scores should not be assumed to equal every displayed match total.

GameStartupController posts player name, player ID, score/trophy values, and device name to `app-hanana.com/worldcupsains/insertmark.php`. Server source is not included. No live service was contacted during this review; availability, authorization, synchronization, and server data handling remain unverified. Review networking before demonstrations with real learner data.

See [validation notes](docs/VALIDATION.md) for source observations and manual checks. Existing crash reports and published artifacts are retained. This documentation change does not assign a new license or establish redistribution rights to bundled assets/audio.

## Attribution

Bundled Pong source credits **Skard Games** and developer **Cavit Baturalp Gürdin**. This repository adds educational/profile integration around that framework; the documentation does not claim sole authorship of the game engine or bundled assets. Preserve original notices and review vendor terms before redistribution.
