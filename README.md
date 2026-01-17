[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
In my MG2 break-down plan, I focused on three main parts: jumping, spawning coins, and scoring/UI. In my Unity Scene, the Player (bird) uses BirdrController.Update() to check Input.GetKeyDown(KeyCode.Space) and trigger jumping, and the grounded logic is handled inside the same script so the player can’t jump in midair. Coins are created by the CoinSpawner GameObject using CoinSpawner.StartCoroutine(SpawnCoins()) (or SpawnCoins() in a loop) to spawn a coinPrefab at a fixed y height but randomized x timing. Each coin uses the Coin script, where collision logic detects when the Player touches it, then calls UIManager.AddPoint(1) and Destroy(gameObject) so the coin disappears and the Points text under the Canvas updates immediately.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
