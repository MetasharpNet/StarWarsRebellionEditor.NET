﻿namespace SwRebellionEditor;

public class MovableLabel : Label
{
    private PictureBox _hostingPictureBox;
    private int _originX;
    private int _originY;
    public int _xDiff;
    private Label _xLabel;
    public int _yDiff;
    private Label _yLabel;
    public ushort X => (ushort)(base.Location.X - _hostingPictureBox.Location.X + _originX);
    public ushort Y => (ushort)(base.Location.Y - _hostingPictureBox.Location.Y + _originY);

    // Used to store the current cursor shape when we start to move the control
    private Cursor _currentCursor;
    // Holds the mouse position relative to the inside of our control when the mouse button goes down
    private Point _cursorOffset;
    // Used by the MoveMove event handler to show that the setup to move the control has completed
    public bool IsMoving;

    public override string ToString()
    {
        return Text + " [" + X + "," + Y + "]";
    }

    public MovableLabel(PictureBox hostingPictureBox, int originX = 0, int originY = 0, Label xLabel = null, Label yLabel = null)
    {
        base.Cursor = Cursors.Hand;
        _hostingPictureBox = hostingPictureBox;
        _originX = originX;
        _originY = originY;
        _xLabel = xLabel;
        _yLabel = yLabel;
        MouseDown += MovableLabel_MouseDown;
        MouseMove += MovableLabel_MouseMove;
        MouseUp += MovableLabel_MouseUp;
    }
    public void MovableLabel_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            // If so, save the current cursor and
            _currentCursor = base.Cursor;
            // replace it with our new image that says were in Movable mode
            base.Cursor = Cursors.SizeAll;
            // Save the location of the mouse pointer relative to the top-left corner of our control
            _cursorOffset = e.Location;
            // Set the mode flag to signal the MouseMove event handler that it needs to now calculate new positions for our control
            IsMoving = true;
            if (_xLabel!= null)
                _xLabel.Text = X.ToString();
            if (_yLabel != null)
                _yLabel.Text = Y.ToString();
        }
    }
    public void MovableLabel_MouseMove(object sender, MouseEventArgs e)
    {
        if (IsMoving)
        {
            // get the screen position of the mouse pointer and map it to the position relative to the top-left corner of our parent container
            var clientPosition = base.Parent.PointToClient(Cursor.Position);
            // Calculate the new position of our control, maintaining the relative position stored by the MoveDown event
            var adjustedLocation = new Point(clientPosition.X - _cursorOffset.X, clientPosition.Y - _cursorOffset.Y);
            // Set the new position of our control
            base.Location = adjustedLocation;
            if (base.Left < _hostingPictureBox.Left)
                base.Left = _hostingPictureBox.Left;
            if (base.Top < _hostingPictureBox.Top)
                base.Top = _hostingPictureBox.Top;
            if (base.Right > _hostingPictureBox.Right + base.Width - 2)
                base.Left = _hostingPictureBox.Right - base.Width + base.Width - 2;
            if (base.Bottom > _hostingPictureBox.Bottom + base.Height - 2)
                base.Top = _hostingPictureBox.Bottom - base.Height + base.Height - 2;
            if (_xLabel != null)
                _xLabel.Text = X.ToString();
            if (_yLabel != null)
                _yLabel.Text = Y.ToString();
        }
    }
    public void MovableLabel_MouseUp(object? sender, MouseEventArgs e)
    {
        IsMoving = false;
        base.Cursor = _currentCursor;
    }
}
