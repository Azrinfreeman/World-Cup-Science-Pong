# Documentation review and manual checks

Baseline: `9844b36b57124ac674bf0d861986b568167e5be5`.

## Scope and checks

README and these notes only. Scripts, scenes, gameplay, packages, settings, assets, outputs, and saved data are unchanged.

Reviewed question banks/selection, goal-to-question integration, correct-answer rewards, collection keys, match reset/save paths, flags, profile indexing, and score-reporting fields. Checked Markdown links, tracked GamePlay scene path, binary build-settings embedded path, and whitespace. Binary enabled flags/order were not fully deserialized.

No Unity compilation, gameplay, device build, or backend request was performed. This is not a full-history security or asset-rights audit.

## Source observations

- QuestionClasses schedules bank insertion after two seconds and appends to its public list. Check startup timing, serialized entries, and repeated insertion before selecting questions.
- QuestionController appends named hierarchy children to questionsList during level selection. Verify repeated level choices do not retain stale or duplicate entries.
- GameController indexes level minus one and assumes configured buttons, question data, and fixed child structures. Test every level's answer count and bounds rather than assuming uniform choices.
- GoalState uses a tween-completion callback and named player/paddle objects to select question UI. Check human/AI ownership, interruption, repeated goals, and return-to-kickoff behavior.
- Collection totals, per-player display values, and profile score/trophy keys use different paths. Check exactly-once rewards, match end, save/reload, profile changes, and reporting values.
- DetailPlayer derives the profile index from only a key's final character. Test ten or more profiles, deletion, and invalid keys.
- Build settings are binary; confirm scene flags/order and platform settings in Unity. Existing published files may be stale, and tracked crash reports may contain local machine information; review distributable contents separately.

## Manual checklist

1. Import in Unity 2022.3.60f1, check compilation/references and actual build settings, and start GamePlay.
2. Use synthetic profiles in a reviewed development networking setup. Test flags, profile creation/switching/deletion, and multi-digit indices.
3. Have a subject reviewer check science answers. Test every level, correct/wrong responses, repeated selection, startup races, and question completion.
4. Exercise AI and human-opponent matches, goal ownership, pause/restart, exactly-once rewards, trophy/score retention, and network failure.
5. Test intended device controls/builds and review bundled asset/vendor permissions and published/crash artifacts before distribution.

The observations above remain unfixed in this documentation-only change.
