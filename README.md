# Puspose
easy create busy indicator

1.add style to xaml resource
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
2. add style to control
```xml
<Grid>
    <Button x:Name="button_busy_basic" Click="Button_busy_basic_Click" Width="50" Height="100">start</Button>
    <Image x:Name="image_busy_basic" IsEnabled="False" Width="50"  Style="{StaticResource busyimage}" VerticalAlignment="Top" HorizontalAlignment="Left" Source="loading.png"/>
</Grid>
```
3. set IsEnabled property control busy state
```csharp
async private void Button_busy_basic_Click(object sender, RoutedEventArgs e)
{
    this.image_busy_basic.IsEnabled = true;
    await Task.Delay(5000);
    this.image_busy_basic.IsEnabled = false;
}
```

enjoy it
