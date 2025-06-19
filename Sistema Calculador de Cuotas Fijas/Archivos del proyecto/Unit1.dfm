object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 414
  ClientWidth = 571
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -12
  Font.Name = 'Segoe UI'
  Font.Style = []
  TextHeight = 15
  object Label1: TLabel
    Left = 30
    Top = 38
    Width = 108
    Height = 15
    Caption = 'monto del prestamo'
  end
  object Label2: TLabel
    Left = 110
    Top = 96
    Width = 28
    Height = 15
    Caption = 'plazo'
  end
  object Label3: TLabel
    Left = 31
    Top = 67
    Width = 107
    Height = 15
    Caption = 'tasa de interes anual'
  end
  object Edit1: TEdit
    Left = 144
    Top = 35
    Width = 121
    Height = 23
    TabOrder = 0
  end
  object Edit2: TEdit
    Left = 144
    Top = 64
    Width = 121
    Height = 23
    TabOrder = 1
  end
  object Edit3: TEdit
    Left = 144
    Top = 93
    Width = 121
    Height = 23
    TabOrder = 2
  end
  object Button1: TButton
    Left = 144
    Top = 122
    Width = 121
    Height = 25
    Caption = 'mostrar resultados'
    TabOrder = 3
    OnClick = Button1Click
  end
  object StringGrid1: TStringGrid
    Left = 8
    Top = 176
    Width = 537
    Height = 201
    DefaultColWidth = 100
    DoubleBuffered = False
    RowCount = 1
    FixedRows = 0
    ParentDoubleBuffered = False
    TabOrder = 4
  end
end
