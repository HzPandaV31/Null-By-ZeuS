using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KrnlAPI;
using WeAreDevs_API;

namespace Null
{
    public partial class In_Game : Form
    {
        public In_Game()
        {
            InitializeComponent();
        }
        KrnlApi krnl = new KrnlApi();
        ExploitAPI wrd = new ExploitAPI();

        Properties.Settings settings = Properties.Settings.Default;

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if(SwitchFpsUnlocker.Checked == true)
            {
                if (RobloxPID.RobloxGetPID() != 0)
                {
                    TrackBarFpsLimit.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Failed to find Roblox process.","Quad X",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    SwitchFpsUnlocker.Checked = false;
                }
            }
            else
            {
                TrackBarFpsLimit.Enabled = false;
                TrackBarFpsLimit.Value = 60;
                labelFps.Text = TrackBarFpsLimit.Value.ToString();
                if (settings.SelectedAPI == 1)
                {
                    krnl.SetFrameRate(TrackBarFpsLimit.Value);
                }
                else if (settings.SelectedAPI == 2)
                {
                    wrd.SendLuaScript("setfpscap(" + TrackBarFpsLimit.Value.ToString() + ")");
                }
            }
        }

        private void TrackBarFpsLimit_Scroll(object sender, ScrollEventArgs e)
        {
            if (TrackBarFpsLimit.Value == 100)
            {
                labelFps.Text = "∞";
            }
            else
            {
                labelFps.Text = TrackBarFpsLimit.Value.ToString();
            }

            if (settings.SelectedAPI == 1)
            {
                if (krnl.IsInjected() == true)
                {
                    if (TrackBarFpsLimit.Value == 100)
                    {
                        krnl.SetFrameRate(9999);
                    }
                    else
                    {
                        krnl.SetFrameRate(TrackBarFpsLimit.Value);
                    }
                }
                else
                {
                    TrackBarFpsLimit.Value = 60;
                    labelFps.Text = TrackBarFpsLimit.Value.ToString();
                    MessageBox.Show("Please Inject!","Quad X",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else if (settings.SelectedAPI == 2)
            {
                if (TrackBarFpsLimit.Value == 100)
                {
                    wrd.SendLuaScript("setfpscap(9999)");
                }
                else
                {
                    wrd.SendLuaScript("setfpscap(" + TrackBarFpsLimit.Value.ToString() + ")");
                }
            }
        }

        private void Check_Tick(object sender, EventArgs e)
        {
            
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            Classes.InGame.InGameSystem(guna2ToggleSwitch1.Checked, @"local ss = game:service'VirtualUser'
                game: service'Players'.LocalPlayer.Idled:connect(function()
                ss: CaptureController()
                ss: ClickButton2(Vector2.new())
                end)", @"local ss = ''
                game: service'Players'.LocalPlayer.Idled:connect(function()
                ss: CaptureController()
                ss: ClickButton2(Vector2.new())
                end)");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((settings.SelectedAPI == 1 && krnl.IsInjected() == true && RobloxPID.RobloxGetPID() != 0) || (RobloxPID.RobloxGetPID() != 0 && settings.SelectedAPI == 2 && wrd.isAPIAttached() == true))
            {
                //anti-afk
                Classes.InGame.InGameSystem(guna2ToggleSwitch1.Checked, @"local ss = game:service'VirtualUser'
                game: service'Players'.LocalPlayer.Idled:connect(function()
                ss: CaptureController()
                ss: ClickButton2(Vector2.new())
                end)", @"local ss = ''
                game: service'Players'.LocalPlayer.Idled:connect(function()
                ss: CaptureController()
                ss: ClickButton2(Vector2.new())
                end)");

                //antilogger
                Classes.InGame.InGameSystem(guna2ToggleSwitch2.Checked, @"game.Players.LocalPlayer.Name = 'null'
game.Players.LocalPlayer.DisplayName = 'null'
game.Players.LocalPlayer.UserId = 1", "");

                //fly
                Classes.InGame.InGameSystem(guna2ToggleSwitch2.Checked, @"local User = game:GetService('UserInputService') local player = game:GetService('Players').LocalPlayer local GuiService = game:GetService('StarterGui') local mouse = game.Players.LocalPlayer:GetMouse() local holdingWKey = false local holdingSKey = false local holdingAKey = false local holdingDKey = false local holdingSpaceKey = false local holdingControlKey = false Speed_1 = -1 mouse.KeyDown:connect(function(key) if key == '-' then Speed_1 = Speed_1 + 0.2 GuiService:SetCore('SendNotification', {Title = 'Speed', Text = 'Speed has gone down';}) end end) mouse.KeyDown:connect(function(key) if key == '=' then Speed_1 = Speed_1 - 0.2 GuiService:SetCore('SendNotification', {Title = 'Speed', Text = 'Speed has gone up';}) end end) mouse.KeyDown:connect(function(key) if key == 'm' then if startup == true then startup = false GuiService:SetCore('SendNotification', {Title = 'Speed', Text = 'Speed is now disabled';}) else startup = true GuiService:SetCore('SendNotification', {Title = 'Speed', Text = 'Speed is now enabled';}) local brick = Instance.new('Part', workspace) brick.Size = Vector3.new(3, 2, 3) brick.CFrame = player.Character.HumanoidRootPart.CFrame + Vector3.new(0, -4, 0) brick.Transparency = 1 brick.Anchored = true brick.Name = 'Brick' mouse.KeyDown:connect(function(key) if key == 'm' then brick:remove() end end) for i = 1, math.huge do brick.CFrame = player.Character.HumanoidRootPart.CFrame + Vector3.new(0, -4, 0) wait(0) end end end end) game:GetService('RunService').Stepped:connect(function() if startup then if WHeld == true then player.Character.HumanoidRootPart.CFrame = player.Character.HumanoidRootPart.CFrame * CFrame.new(0,0,Speed_1) end end end) game:GetService('RunService').Stepped:connect(function() if startup then if SHeld == true then player.Character.HumanoidRootPart.CFrame = player.Character.HumanoidRootPart.CFrame * CFrame.new(0,0,-Speed_1) end end end) game:GetService('RunService').Stepped:connect(function() if startup then if AHeld == true then player.Character.HumanoidRootPart.CFrame = player.Character.HumanoidRootPart.CFrame * CFrame.new(Speed_1,0,0) end end end) game:GetService('RunService').Stepped:connect(function() if startup then if DHeld == true then player.Character.HumanoidRootPart.CFrame = player.Character.HumanoidRootPart.CFrame * CFrame.new(-Speed_1,0,0) end end end) game:GetService('RunService').Stepped:connect(function() if startup then if SpaceHeld == true then player.Character.HumanoidRootPart.CFrame = player.Character.HumanoidRootPart.CFrame * CFrame.new(0,-Speed_1,0) end end end) game:GetService('RunService').Stepped:connect(function() if startup then if ControlHeld == true then player.Character.HumanoidRootPart.CFrame = player.Character.HumanoidRootPart.CFrame * CFrame.new(0,Speed_1,0) end end end) User.InputBegan:Connect(function(inputObject) if(inputObject.KeyCode==Enum.KeyCode.W) then holdingWKey = true WHeld = true end if(inputObject.KeyCode==Enum.KeyCode.S) then holdingSKey = true SHeld = true end if(inputObject.KeyCode==Enum.KeyCode.A) then holdingAKey = true AHeld = true end if(inputObject.KeyCode==Enum.KeyCode.D) then holdingDKey = true DHeld = true end if(inputObject.KeyCode==Enum.KeyCode.LeftControl) then holdingControlKey = true ControlHeld = true end if(inputObject.KeyCode==Enum.KeyCode.Space) then holdingSpaceKey = true SpaceHeld= true end if(inputObject.KeyCode==Enum.KeyCode.W) then holdingUKey = true WHeld = true end end) User.InputEnded:Connect(function(inputObject) if(inputObject.KeyCode==Enum.KeyCode.W) then holdingWKey = false WHeld = false end if(inputObject.KeyCode==Enum.KeyCode.S) then holdingSKey = false SHeld = false end if(inputObject.KeyCode==Enum.KeyCode.A) then holdingAKey = false AHeld = false end if(inputObject.KeyCode==Enum.KeyCode.D) then holdingDKey = false DHeld = false end if(inputObject.KeyCode==Enum.KeyCode.LeftControl) then holdingShiftKey = false ControlHeld = false end if(inputObject.KeyCode==Enum.KeyCode.Space) then holdingSpaceKey = false SpaceHeld = false end end)", "");

                //noclip
                Classes.InGame.InGameSystem(guna2ToggleSwitch2.Checked, @"game.Players.LocalPlayer.Name = 'null'
game.Players.LocalPlayer.DisplayName = 'null'
game.Players.LocalPlayer.UserId = 1", "");

                timer1.Stop();
            }

        }

        private void guna2ToggleSwitch2_CheckedChanged_1(object sender, EventArgs e)
        {
            Classes.InGame.InGameSystem(guna2ToggleSwitch2.Checked, @"game.Players.LocalPlayer.Name = 'null'
game.Players.LocalPlayer.DisplayName = 'null'
game.Players.LocalPlayer.UserId = 1", "");
        }

        private void guna2ToggleSwitch4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
