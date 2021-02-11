# Unity Automated Build Template
![Basic Unity build](https://github.com/braustin20/unity-auto-build/workflows/Basic%20Unity%20build/badge.svg)
## Overview
This project is a working example on how to implement GitHub action based automated builds for Unity.
The basic build example uses a Unity 2020.1.11f1 image to build for Windows and OSX.

## Getting Started
The actions and configuration used in this project were obtained from the game.ci website - https://game.ci/docs/github/getting-started.
Before running the build in your own repository, you will need to select a compatible Unity version and then complete a one time activation process.

### Activation
Automated builds can be performed using any Unity version contained in the image list provided by docker hub user gableroux - https://hub.docker.com/r/gableroux/unity3d/tags.
Once you have found the Unity version you would like to use, follow the steps below
- Update the `unityVersion` variable in the `.github/workflows/activation.yml` script to match your selected version and push to the master branch.
- Run the activation action on GitHub and download the `*.alf` activation file from the action's artifacts.
- Visit https://license.unity3d.com, upload your `.alf` file, and follow the instructions to receive a `.ulf` license file.
- Copy the contents of the `.ulf` file into a GitHub secret named `UNITY_LICENSE`

More information on activation can be found here - https://game.ci/docs/github/activation

### Running builds
By default a new build will be triggered on each push to the `main` branch. You may also manually run a workflow from the GitHub actions menu.
The basic build includes Windows and OSX builds. Additional platforms can be added by modifying the `main.yml` file.
Completed builds will be available in the artifacts section of the GitHub action workflow.

## Customization
For details on how to add additional platforms and build customizations, visit the game.ci website - https://game.ci/docs/github/getting-started

## Supported Unity Versions
https://hub.docker.com/r/gableroux/unity3d/tags
