using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class UnitySpecWindow : EditorWindow
{
    private Generator _generator = new();

    [MenuItem("Window/UnitySpec")]
    public static void ShowExample()
    {
        UnitySpecWindow wnd = GetWindow<UnitySpecWindow>();
        wnd.titleContent = new GUIContent("UnitySpec");
    }

    public void CreateGUI()
    {
        VisualElement root = rootVisualElement;

        root.Add(GetLabel());
        root.Add(GetButton());
    }

    private static Label GetLabel()
    {
        return new Label()
        {
            style =
            {
                whiteSpace = WhiteSpace.Normal
            },
            text = "Welcome to UnitySpec, clik the button below to generate test files."
        };
    }

    private Button GetButton()
    {
        Button button = new Button()
        {
            style =
            {
                whiteSpace = WhiteSpace.Normal
            },
            text = "Click here to generate test files."
        };
        button.RegisterCallback((ClickEvent evt) =>
        {
            _generator.Generate();
        });
        return button;
    }
}
