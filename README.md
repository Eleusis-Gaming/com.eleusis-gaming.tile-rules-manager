# Tile Rules Manager

The Tile Rules Manager is a Unity package designed to create tile rules for 3D tiles as ScriptableObjects. These rules can be used with a Wave Function Collapse (WFC) algorithm to generate maps. This package provides an editor window to manage tile configurations, including their sockets, neighbors, and variants.

## Features

- **Tile Configuration Management**: Easily add, remove, and configure tile rules.
- **Socket Management**: Define sockets for the sides, top and bottom of tiles.
- **Neighbor Management**: Specify allowed neighboring rules for tiles.
- **Variant Management**: Create multiple variants(rotations) for each tile configuration.

## Installation

1. Clone or download the package into your Unity project's `Packages` directory.
2. Ensure the directory name matches the package name: `com.eleusis-gaming.tile-rules-manager`.

## Usage

1. Open the Tile Rules Manager window from the Unity menu: `Tools -> Tile Rules Manager`.
2. Use the window to add and configure tile rules:
    - **Output Path**: Set the path where the tile rules will be saved.
    - **Add Tile Config**: Add a new tile configuration.
    - **Tile Rule Sections**: Configure the base properties, neighbors, sockets, and variants for each tile.
3. Click `Generate Tile Rules` to save the configurations to the specified output path.

## Example

```csharp
using UnityEngine;
using UnityEditor;
using Editor.Scripts;

public class ExampleUsage : MonoBehaviour
{
    void Start()
    {
        // Example of how to use the generated tile rules with your WFC algorithm
        var tileRules = Resources.LoadAll<TileRuleConfiguration>("TileRules");
        // Initialize your WFC algorithm with the tile rules
    }
}
```

## Contributing

Contributions are welcome! Please submit a pull request or open an issue to discuss your ideas.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.