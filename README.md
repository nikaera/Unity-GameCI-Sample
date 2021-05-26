# Unity-GameCI-Sample 🎮
Sample project for building a CI environment for Unity using [GameCI](https://game.ci/) with GitHub Actions.  
You can see the actual execution of GameCI's GitHub Actions from the [Actions tab](https://github.com/nikaera/Unity-GameCI-Sample/actions).

## 🧪 Samples 

* [Activation](https://github.com/nikaera/Unity-GameCI-Sample/blob/main/.github/workflows/activation.yml)
  * Activate the Unity License required by GameCI.
* [Test runner](https://github.com/nikaera/Unity-GameCI-Sample/blob/main/.github/workflows/test.yml)
  * Run the [PlayMode and EditMode tests](https://docs.unity3d.com/Packages/com.unity.test-framework@1.1/manual/index.html) and upload the results to the [artifact](https://docs.github.com/en/actions/guides/storing-workflow-data-as-artifacts).
* [Builder](https://github.com/nikaera/Unity-GameCI-Sample/blob/main/.github/workflows/webgl_build.yml)
  * WebGL build with GameCI and make it available on [GitHub Pages](https://docs.github.com/en/pages/getting-started-with-github-pages/about-github-pages).
  * Here is the URL to check the WebGL build in GameCI.
    * https://nikaera.com/Unity-GameCI-Sample/WebGL/WebGL/

## ▶️ Usage

Copy the sample you want to use from [the folder containing the workflow files](https://github.com/nikaera/Unity-GameCI-Sample/blob/main/.github/workflows/) to the workflow folder of your own project, and feel free to use it by modifying it according to your needs!

### Usage Notes

* The `unityVersion` listed in the sample workflow file should be changed to match the version of your Unity project.

## 🎁 Contributing

If you have any questions, please feel free to create an Issue or PR for you.

## License

[MIT](https://github.com/nikaera/Unity-GameCI-Sample/blob/main/LICENSE)
