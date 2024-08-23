This article explains how to customize the space between the stroke and image or avatar in [.NET MAUI AvatarView](https://www.syncfusion.com/maui-controls/maui-avatarview). This can be achieved by adjusting the `WidthRequest`, `HeightRequest`, and `CornerRadius` properties of the [Border](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/border?view=net-maui-8.0) control that wraps the `Avatar View`. Below is an example of how to implement this in your application.

**XAML**

```xml
<StackLayout Spacing="5">
    <Label Text="Circle Shape Avatar:" HorizontalOptions="Center"/>
    <Border x:Name="circleBorder" WidthRequest="80" HeightRequest="80"
            Stroke="Black" StrokeThickness="2">
        <Border.StrokeShape>
            <RoundRectangle x:Name="circleRadius" CornerRadius="40"/>
        </Border.StrokeShape>
        <core:SfAvatarView ContentType="AvatarCharacter" AvatarShape="Circle"/>
    </Border>
    ...
</StackLayout>
```

**Output**

![AvatarView_Space.gif](https://support.syncfusion.com/kb/agent/attachment/article/17197/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI4NjA2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.wgn968v8d-fzMhqQ54is7Cefo7HJIyIh3ab5iBNJ8A0)

**Requirements to run the demo**
 
To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)
 
**Troubleshooting:**

**Path too long exception** 

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.