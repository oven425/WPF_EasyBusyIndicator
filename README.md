# Puspose

```xml
<Style x:Key="busyimage" TargetType="{x:Type FrameworkElement}">
    <Setter Property="RenderTransformOrigin" Value="0.5,0.5"/>
    <Setter Property="RenderTransform">
        <Setter.Value>
            <RotateTransform Angle="0" />
        </Setter.Value>
    </Setter>
    <Style.Triggers>
        <Trigger Property="IsEnabled" Value="true">
            <Trigger.EnterActions>
                <BeginStoryboard Name="rotate">
                    <Storyboard>
                        <DoubleAnimation Storyboard.TargetProperty="RenderTransform.Angle"  To="360" Duration="0:0:5" RepeatBehavior="Forever" />
                    </Storyboard>
                </BeginStoryboard>
            </Trigger.EnterActions>
            <Trigger.ExitActions>
                <StopStoryboard BeginStoryboardName="rotate"/>
            </Trigger.ExitActions>
        </Trigger>
    </Style.Triggers>
</Style>
```
