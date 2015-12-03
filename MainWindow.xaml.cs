<Window
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Command_Editer"
        xmlns:i="http://schemas.microsoft.com/expression/2010/interactivity"
        xmlns:chrome="http://schemes.grabacr.net/winfx/2014/chrome"
        xmlns:ed="http://schemas.microsoft.com/expression/2010/drawing" 
        x:Class="Command_Editer.MainWindow"
        mc:Ignorable="d"
        Title="MainWindow" Height="744.444" Width="1100.502" WindowStyle="None">
    <Window.Resources>
        <Storyboard x:Key="visible_slider">
            <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty="(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)" Storyboard.TargetName="slider">
                <EasingDoubleKeyFrame KeyTime="0:0:0.7" Value="24">
                    <EasingDoubleKeyFrame.EasingFunction>
                        <CircleEase EasingMode="EaseInOut"/>
                    </EasingDoubleKeyFrame.EasingFunction>
                </EasingDoubleKeyFrame>
            </DoubleAnimationUsingKeyFrames>
            <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty="(UIElement.Opacity)" Storyboard.TargetName="slider">
                <EasingDoubleKeyFrame KeyTime="0:0:0.7" Value="1">
                    <EasingDoubleKeyFrame.EasingFunction>
                        <CircleEase EasingMode="EaseInOut"/>
                    </EasingDoubleKeyFrame.EasingFunction>
                </EasingDoubleKeyFrame>
            </DoubleAnimationUsingKeyFrames>
        </Storyboard>
        <Storyboard x:Key="down_label">
            <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty="(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)" Storyboard.TargetName="label4">
                <EasingDoubleKeyFrame KeyTime="0:0:0.7" Value="25">
                    <EasingDoubleKeyFrame.EasingFunction>
                        <CircleEase EasingMode="EaseInOut"/>
                    </EasingDoubleKeyFrame.EasingFunction>
                </EasingDoubleKeyFrame>
            </DoubleAnimationUsingKeyFrames>
        </Storyboard>
        <Storyboard x:Key="invisible_slider">
            <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty="(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)" Storyboard.TargetName="slider">
                <EasingDoubleKeyFrame KeyTime="0" Value="23"/>
                <EasingDoubleKeyFrame KeyTime="0:0:0.7" Value="0">
                    <EasingDoubleKeyFrame.EasingFunction>
                        <CircleEase EasingMode="EaseInOut"/>
                    </EasingDoubleKeyFrame.EasingFunction>
                </EasingDoubleKeyFrame>
            </DoubleAnimationUsingKeyFrames>
        </Storyboard>
        <Storyboard x:Key="invisible_Slider">
            <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty="(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)" Storyboard.TargetName="slider">
                <EasingDoubleKeyFrame KeyTime="0" Value="23"/>
                <EasingDoubleKeyFrame KeyTime="0:0:0.8" Value="0">
                    <EasingDoubleKeyFrame.EasingFunction>
                        <CircleEase EasingMode="EaseInOut"/>
                    </EasingDoubleKeyFrame.EasingFunction>
                </EasingDoubleKeyFrame>
            </DoubleAnimationUsingKeyFrames>
            <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty="(UIElement.Opacity)" Storyboard.TargetName="slider">
                <EasingDoubleKeyFrame KeyTime="0" Value="1"/>
                <EasingDoubleKeyFrame KeyTime="0:0:0.8" Value="0">
                    <EasingDoubleKeyFrame.EasingFunction>
                        <CircleEase EasingMode="EaseInOut"/>
                    </EasingDoubleKeyFrame.EasingFunction>
                </EasingDoubleKeyFrame>
            </DoubleAnimationUsingKeyFrames>
        </Storyboard>
        <Storyboard x:Key="Up_label">
            <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty="(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)" Storyboard.TargetName="label4">
                <EasingDoubleKeyFrame KeyTime="0" Value="23"/>
                <EasingDoubleKeyFrame KeyTime="0:0:0.7" Value="0">
                    <EasingDoubleKeyFrame.EasingFunction>
                        <CircleEase EasingMode="EaseInOut"/>
                    </EasingDoubleKeyFrame.EasingFunction>
                </EasingDoubleKeyFrame>
            </DoubleAnimationUsingKeyFrames>
        </Storyboard>
    </Window.Resources>
    <Window.Triggers>
        <EventTrigger RoutedEvent="FrameworkElement.Loaded">
        </EventTrigger>
    </Window.Triggers>
    <WindowChrome.WindowChrome>
        <WindowChrome CaptionHeight="30"
                      ResizeBorderThickness="0" />
    </WindowChrome.WindowChrome>
    <i:Interaction.Behaviors>
        <chrome:MetroChromeBehavior ActiveBrush="DeepSkyBlue"
    		InactiveBrush="DarkGray"
    		Mode="VisualStudio2013" />
    </i:Interaction.Behaviors>
    <Grid Background="#FF002323">
        <Grid HorizontalAlignment="Center" Height="32" VerticalAlignment="Top" Width="1093" Background="#FF1B1B1B">
            <Button x:Name="button_max" Content="1" Style="{DynamicResource CaptionButtonStyleKey}" Height="18" Margin="1063,5,11,0" VerticalAlignment="Top" Width="19" Background="{x:Null}" Foreground="White" FontSize="13.333" Click="button_max_Click"/>
            <Button x:Name="button_min" Content="0" Style="{DynamicResource CaptionButtonStyleKey}" HorizontalAlignment="Left" Height="18" Margin="1021,5,0,0" VerticalAlignment="Top" Width="19" Background="{x:Null}" Foreground="White" FontSize="13.333" Click="button_min_Click"/>
            <Button x:Name="button" Content="r" Style="{DynamicResource CaptionButtonStyleKey}" HorizontalAlignment="Left" Height="18" Margin="1040,5,0,0" VerticalAlignment="Top" Width="19" Background="{x:Null}" Foreground="White" FontSize="13.333" Click="button_Click"/>
            <Label x:Name="label" Content="Command Editer" HorizontalAlignment="Left" Height="30" VerticalAlignment="Top" Width="175" Foreground="White" Margin="0,2,0,0" FontSize="16"/>
        </Grid>
        <TabControl x:Name="tabControl" HorizontalAlignment="Left" Height="607" Margin="298,43.339,-0.498,0" VerticalAlignment="Top" Width="795" BorderBrush="{x:Null}" SelectionChanged="tabControl_SelectionChanged">
            <TabItem Header="Summon" Background="White" BorderBrush="{x:Null}" Foreground="Black">
                <Grid Background="#FF363636" Margin="1,0,-1,0">
                    <GroupBox x:Name="groupBox1" Header="Basic configuration" Margin="18,167,478,66" Foreground="White">
                        <Grid Height="289" Margin="4,31,7,0" VerticalAlignment="Top" Background="#FF3C3C3C" OpacityMask="White">
                            <CheckBox x:Name="tag_noai" Content="NoAI" HorizontalAlignment="Left" Height="18" Margin="10,10,0,0" VerticalAlignment="Top" Width="116" Foreground="White" Checked="tag_noai_Checked" Unchecked="tag_noai_Unchecked"/>
                            <Slider x:Name="slider" Height="18" Margin="10,32.357,64,0" VerticalAlignment="Top" Opacity="0" RenderTransformOrigin="0.5,0.5" Maximum="127" ValueChanged="slider_ValueChanged">
                                <Slider.RenderTransform>
                                    <TransformGroup>
                                        <ScaleTransform/>
                                        <SkewTransform/>
                                        <RotateTransform/>
                                        <TranslateTransform/>
                                    </TransformGroup>
                                </Slider.RenderTransform>
                            </Slider>
                            <CheckBox x:Name="tag_fire" Content="Fire" HorizontalAlignment="Left" Height="18" Margin="10,33,0,0" VerticalAlignment="Top" Width="50" Foreground="White" Checked="tag_fire_Checked" Unchecked="tag_fire_Unchecked"/>
                            <Label x:Name="label4" Content="Time: 0/127 tick" Height="26" Margin="10,51,1,0" VerticalAlignment="Top" Foreground="White" RenderTransformOrigin="0.5,0.5">
                                <Label.RenderTransform>
                                    <TransformGroup>
                                        <ScaleTransform/>
                                        <SkewTransform/>
                                        <RotateTransform/>
                                        <TranslateTransform/>
                                    </TransformGroup>
                                </Label.RenderTransform>
                            </Label>
                            <ToggleButton x:Name="Chenged_time_button" Content="Chenged time" Height="20" Margin="60,31.666,114,0" VerticalAlignment="Top" Unloaded="Chenged_time_button_Unloaded" Unchecked="Chenged_time_button_Unchecked" IsEnabled="False">
                                <ToggleButton.Triggers>
                                    <EventTrigger RoutedEvent="ToggleButton.Checked">
                                        <BeginStoryboard Storyboard="{StaticResource visible_slider}"/>
                                        <BeginStoryboard Storyboard="{StaticResource down_label}"/>
                                    </EventTrigger>
                                    <EventTrigger RoutedEvent="ToggleButton.Unchecked">
                                        <BeginStoryboard Storyboard="{StaticResource invisible_Slider}"/>
                                        <BeginStoryboard Storyboard="{StaticResource Up_label}"/>
                                    </EventTrigger>
                                </ToggleButton.Triggers>
                            </ToggleButton>
                        </Grid>
                    </GroupBox>
                    <ComboBox x:Name="comboBox" HorizontalAlignment="Left" Height="27" Margin="10,32,0,0" VerticalAlignment="Top" Width="404" BorderBrush="#FF979797" Background="#FF360000" Foreground="Black">
                        <ComboBoxItem Content="{Binding SystemFile.Data.EntityIDs.csv}" Foreground="Black" Background="#FF222222" BorderBrush="#FF222222" OpacityMask="#FF222222"/>
                    </ComboBox>
                    <Label x:Name="label1" Content="type" HorizontalAlignment="Left" Height="27" Margin="10,5,0,0" VerticalAlignment="Top" Width="148" Foreground="White"/>
                    <Label x:Name="label2" Content="tag" HorizontalAlignment="Left" Height="25" Margin="28,186,0,0" VerticalAlignment="Top" Width="97" Foreground="White"/>
                    <TextBox x:Name="x_text" HorizontalAlignment="Left" Height="20" Margin="41,85,0,0" TextWrapping="Wrap" Text="0" VerticalAlignment="Top" Width="34"/>
                    <TextBox x:Name="y_text" HorizontalAlignment="Left" Height="20" Margin="41,111,0,0" TextWrapping="Wrap" Text="0" VerticalAlignment="Top" Width="34"/>
                    <TextBox x:Name="z_text" HorizontalAlignment="Left" Height="20" Margin="41,138,0,0" TextWrapping="Wrap" Text="0" VerticalAlignment="Top" Width="34"/>
                    <Label x:Name="x_dis" Content="X" HorizontalAlignment="Left" Height="23" Margin="18,82,0,0" VerticalAlignment="Top" Width="18" Foreground="White"/>
                    <Label x:Name="y_dis" Content="Y" HorizontalAlignment="Left" Height="23" Margin="18,108,0,0" VerticalAlignment="Top" Width="18" Foreground="White"/>
                    <Label x:Name="z_dis" Content="Z" HorizontalAlignment="Left" Height="45" Margin="18,136,0,0" VerticalAlignment="Top" Width="18" Foreground="White"/>
                    <CheckBox x:Name="x_relative" Content="X to Relative coordinate" HorizontalAlignment="Left" Height="15" Margin="80,87,0,0" VerticalAlignment="Top" Width="161" Foreground="White"/>
                    <CheckBox x:Name="y_relative" Content="Y to Relative coordinate" HorizontalAlignment="Left" Height="14" Margin="80,114,0,0" VerticalAlignment="Top" Width="161" Foreground="White"/>
                    <CheckBox x:Name="z_relative" Content="Z to Relative coordinate" HorizontalAlignment="Left" Height="15" Margin="80,140,0,0" VerticalAlignment="Top" Width="161" Foreground="White"/>
                    <GroupBox x:Name="groupBox" Header="Spawn Position" HorizontalAlignment="Left" Height="100" Margin="16,69,0,0" VerticalAlignment="Top" Width="228" Foreground="White" RenderTransformOrigin="0.642,0.66"/>
                </Grid>
            </TabItem>
            <TabItem Header="Give">
                <TabItem.Background>
                    <LinearGradientBrush EndPoint="0,1" StartPoint="0,0">
                        <GradientStop Color="#FFF0F0F0" Offset="0"/>
                        <GradientStop Color="White" Offset="1"/>
                    </LinearGradientBrush>
                </TabItem.Background>
                <Grid Background="#FF363636" Margin="1,0,-1,0">
                    <ComboBox x:Name="comboBox_item" HorizontalAlignment="Left" Height="27" Margin="10,41,0,0" VerticalAlignment="Top" Width="404" BorderBrush="#FF979797" Background="#FF360000" Foreground="Black">
                        <ComboBoxItem Content="{Binding SystemFile.Data.EntityIDs.csv}" Foreground="Black" Background="#FF222222" BorderBrush="#FF222222" OpacityMask="#FF222222"/>
                    </ComboBox>
                    <Label x:Name="label6" Content="Type" HorizontalAlignment="Left" Height="28.579" Margin="12,12.421,0,0" VerticalAlignment="Top" Width="125" Foreground="White"/>
                    <GroupBox x:Name="groupBox2" Header="Common setting" Margin="10,73,375,111.339" Foreground="#FFFFFFFF"/>
                    <Label x:Name="label7" Content="Color" HorizontalAlignment="Right" Height="27.333" Margin="0,91.588,208.5,0" VerticalAlignment="Top" Width="154.667" Foreground="White"/>
                    <Button x:Name="r_up" Content="5" Style="{DynamicResource ResourceKey=CaptionButtonStyleKey}" HorizontalAlignment="Right" Height="12.5" Margin="0,112.424,323.667,0" VerticalAlignment="Top" Width="13" Click="r_up_Click"/>
                    <Button x:Name="r_down" Content="6" Style="{DynamicResource CaptionButtonStyleKey}" HorizontalAlignment="Right" Height="12.912" Margin="0,120.924,324.334,0" VerticalAlignment="Top" Width="12.333" Click="r_down_Click" IsEnabled="False"/>
                    <TextBox x:Name="r_val" HorizontalAlignment="Right" Height="16.579" Margin="0,114.753,335.002,0" TextWrapping="Wrap" Text="0" VerticalAlignment="Top" Width="31" Background="{x:Null}" Foreground="White" TextChanged="r_val_TextChanged"/>
                    <Button x:Name="r_down_g" Content="6" Style="{DynamicResource CaptionButtonStyleKey}" HorizontalAlignment="Right" Height="12.912" Margin="0,120.924,278.166,0" VerticalAlignment="Top" Width="12.333" Click="r_downg_Click" IsEnabled="False"/>
                    <TextBox x:Name="r_val_g" HorizontalAlignment="Right" Height="16.579" Margin="0,114.753,288.834,0" TextWrapping="Wrap" Text="0" VerticalAlignment="Top" Width="31" Background="{x:Null}" Foreground="White" TextChanged="r_valg_TextChanged"/>
                    <Label x:Name="label8_Copy" Content="G" HorizontalAlignment="Right" Height="24.246" Margin="0,131.332,298.002,0" VerticalAlignment="Top" Width="21.332" Foreground="White"/>
                    <Label x:Name="label8_Copy1" Content="R" HorizontalAlignment="Right" Height="24.246" Margin="0,131.332,344.67,0" VerticalAlignment="Top" Width="21.332" Foreground="White"/>
                    <Button x:Name="r_up_g" Content="5" Style="{DynamicResource ResourceKey=CaptionButtonStyleKey}" HorizontalAlignment="Right" Height="12.5" Margin="0,112.424,277.696,0" VerticalAlignment="Top" Width="13" Click="r_upg_Click"/>
                </Grid>
            </TabItem>
        </TabControl>
        <Grid HorizontalAlignment="Left" Height="26" Margin="0,710,0,0" VerticalAlignment="Top" Width="1093" Background="#FF7975D8">
            <ProgressBar x:Name="loadbar" HorizontalAlignment="Left" Height="26" Margin="961,0,-1,0" VerticalAlignment="Top" Width="133" Background="#FF4A5BFF" Maximum="1"/>
            <Label x:Name="label3" Content="準備完了" Height="26" Margin="0,0,133,0" VerticalAlignment="Top" Foreground="White"/>
        </Grid>
        <Grid Height="67.667" Margin="-2.68,0,27.347,25.11" VerticalAlignment="Bottom">
            <TextBox x:Name="resultBox" HorizontalAlignment="Left" Height="18" Margin="2.5,40.393,0,0" TextWrapping="Wrap" Text="/summon" VerticalAlignment="Top" Width="1065.335" Foreground="White" Background="#FF232323" TextInput="resultBox_TextInput"/>
            <Button x:Name="button1" Content="Output" Height="18" Margin="2.5,1.614,0,0" VerticalAlignment="Top" Click="button1_Click_1" HorizontalAlignment="Left" Width="80"/>
            <Label x:Name="label5" Content="Result" Margin="0.5,17.001,0,26.666" Foreground="White" HorizontalAlignment="Left" Width="77"/>
            <Label x:Name="label5_Copy" Content="現在7文字 : チャットで入力できます。" Margin="79,19.334,-609.502,24.333" Foreground="White"/>
        </Grid>
        <TreeView x:Name="treeView" HorizontalAlignment="Left" Margin="2,72.579,0,97.777" Width="231" Foreground="White" Background="#FF004949">
            <TreeViewItem Foreground="White" Header="Command">
                <TreeViewItem x:Name="Summon" Foreground="White" Header="Summon" MouseDoubleClick="Summon_MouseDoubleClick"/>
                <TreeViewItem Foreground="White" Header="Give"/>
            </TreeViewItem>
        </TreeView>
    </Grid>
</Window>
