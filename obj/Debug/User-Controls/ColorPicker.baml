   M S B A M L   `   `   `  ����  SimpleTextEditor"    SimpleTextEditor.ColorPicker   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      $��449.091��5      $��493.117��6     � 	Resources  5         CheckerboardBrush j� Stretch j� TileMode j� 
AlignmentX j� 
AlignmentY j� Viewport j� ViewportUnits L� Drawing � Brush	 � Geometry
 �� Rect��%�  &	        L� 5   
   $
 None=�5
   	   $
 Tile=�6   $
 Left=�5      $	 Top=�6$   $ 	0,0,10,10�5      $ Absolute=�6'    5      I� 5      .��5      �  �	sc# 1,1,1	 5      �� 5      $
 	0,0,10,10�60   5      � 5       �sc# 0.5,0.5,0.5	 5      �� 5      $
 0,0,5,5�60   5      � 5       �sc# 0.5,0.5,0.5	 5      �� 5      $
 5,5,5,5�60   5      5       5"      5#      .��5%      � 
�������$��
0,0,21,106q�6    � RowDefinitions 5'   
   �� 5(      $��35 �6   �� 5)      $	��230 �6   �� 5*      $��70 �6   .+�5-   
   �� $��0��6   $��35��6"   $��Stretch=�5/       �� Orientation$ 
Horizontal=�51      
���   �.+�54      �� $��Pick swatch type��6   
�������$
��Bold"�56   '   $��Center=�58      �� 59      -   5         ��Name$ 
ImgSqaure1��59      $��20��5;      $��20��6    $l��fC:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\Images\ColorSwatchSquare.png��5=      $��45,0,0,0q�5?       � ToolTip$ Square swatch1��5A      5C      �� 5D      -   5        $ 
ImgSqaure2��5D      $��20��5F      $��20��6    $m��gC:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\Images\ColorSwatchSquare2.png��5H      $��5,0,0,0q�6�   $ Square swatch2��5J      5L      �� 5M      -   5        $ 
ImgCircle1��5M      $��20��6(   $��20��64   $l��fC:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\Images\ColorSwatchCircle.png��5O      $��5,0,0,0q�6�   $ Circle swatch1��5Q      5S      5T      � 5V   
   $��1��6   $	��230��6   $	��Top=�5X       � ColumnDefinitions 5Y      �� 5Z      $	��170 �6#   �� 5[      $	��170 �6#   �� 5\      $	��170 �6#   .+�5`      � $��0��6   $��0��5b      $��	10,30,0,0q�6#   .+�5d      �� 
���   �$��2q�6-   $��Center=�5f      $	��Top=�5h      
�������$	��154��5l      $	��154��6!   5m      �� 5q      -   5        $ 
ColorImage��5q      $	��150��5s      $	��150��6$   $��Center=�5u      $	��Top=�5w      $��2q�60   $l��fC:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\Images\ColorSwatchSquare.png��5y      �� 5{      -   5         ��Name$ 	CanvImage��5{      $	��150��5}      $	��150��6$   $��Center=�5      
������ $	��Top=�5�      $��2q�60   .+�5�      A� -   5         A�Name$ ellipsePixel��5�      $��10��64   $��10��5�      
���   �
������� �� Left$ 0��5�      
 �� Top$ 0��6(   5�      5�      �� 5�      $��1��6   $ Vertical=�6)   .+�5�      �� $��Preview��6   $��5,0,0,0q�6*   $
��Left=�5�      
���   �$
��Bold"�5�   )   $��Center=�5�      �� 5�      $��4,5,10,0q�6   $	��154��6+   $	��154��5�      $
��Left=�5�      
���   �$��2q�5�   -   #��[  5�      ._�5�      �� -   5        $��previewPresenter��5�   #   $��0q�5�      $	��150��6$   $	��150��60    �� Strokes$� �AOcBAxdIEESAgYAERYQBGwIAJAFGhAEbAgAk                          AQUBOBkgMgkA9P8CAekiOkUzCQD4nwIBWiA6RTgIAP4DAAAAg                          H8RAACAPx8JEQAAAAAAAPA/CpYBNIfm3uajgcQgUUiUkjUelE                          al0KkUBh0HichlM1mtJotZp9JodDl8jk8ZgcBiUOjUYl08                          m0+l0+lFCjksjESAh+kg6auNwaEwSBQiEQyLRKTRiVSiUSSORy                          LQ6JQSBIPFYnKZTL5fOZfMZXL4/H47DYLBYHFoJLIpEo9GgIP3OB5                          PlxLCJiZmU1MISSi4SJiS74+D4+4o��5�      5�      5�      �� 5�      $��2��6   $ Vertical=�6)   .+�5�      �� $ 
Horizontal=�6   $��0,30,0,0q�66   .+�5�      �� $��A��6   $��5,0,0,0q�6(   $
��Left=�5�      
���   �$
��Bold"�5�   0   $��Center=�5�      �� 5�       �� CornerRadius$ 5��6   
���   �
�������$��2q�5�      $��50��5�      $��30��6(   ._�5�      �� -   5         ��Name$ txtAlpha��5�   "   $��0q�5�      
�������
������ $��5,1,5,1q�5�       �� 
IsReadOnly . 6.   5�      �� 5�      $ 5��6   
���   �
�������$��2q�5�      $��10,0,0,0q�61   $��50��5�      $��30��6(   ._�5�      �� -	   5        $ txtAlphaHex��5�   "   $��0q�67   
�������
������ $��5,1,5,1q�5�       . 6.   5�      5�      �� 5�      $ 
Horizontal=�6   $��0,5,0,0q�66   .+�5�      �� $��R��6   $��5,0,0,0q�6(   $
��Left=�5�      
���   �$
��Bold"�5�   0   $��Center=�5�      �� 5�      $ 5��6   
���   �
�������$��2q�5�      $��50��61   $��30��5�      ._�5�      �� -
   5        $ txtRed��5�   "   $��0q�5�      
�������
������ $��5,1,5,1q�5�       . 6.   5�      �� 5�      $ 5��6   
���   �
�������$��2q�5�      $��10,0,0,0q�61   $��50��5�      $��30��6(   ._�5�      �� -   5        $ 	txtRedHex��5�   "   $��0q�5      
�������
������ $��5,1,5,1q�5      . 6.   5     5     �� 5     $ 
Horizontal=�6   $��0,5,0,0q�66   .+�5	     �� $��G��6   $��5,0,0,0q�6(   $
��Left=�5     
���   �$
��Bold"�5  0   $��Center=�5     �� 5     $ 5��6   
���   �
�������$��2q�5     $��50��61   $��30��6<   ._�5     �� -   5        $ txtGreen��5  "   $��0q�64   
�������
������ $��5,1,5,1q�5      . 6.   5     �� 5     $ 5��6   
���   �
�������$��2q�5     $��10,0,0,0q�61   $��50��5!     $��30��6(   ._�5"     �� -   5        $ txtGreenHex��5"  "   $��0q�67   
�������
������ $��5,1,5,1q�5&      . 6.   5'     5(     �� 5*     $ 
Horizontal=�6   $��0,5,0,0q�66   .+�5+     �� $��B��6   $��5,0,0,0q�6(   $
��Left=�5-     
���   �$
��Bold"�5/  /   $��Center=�51     �� 52     $ 5��6   
���   �
�������$��2q�56     $��50��60   $��30��6;   ._�57     �� -   5        $ txtBlue��57  "   $��0q�59     
�������
������ $��5,1,5,1q�5=      . 6-   5>     �� 5?     $ 5��6   
���   �
�������$��2q�5C     $��10,0,0,0q�61   $��50��5E     $��30��6(   ._�5F     �� -   5        $ 
txtBlueHex��5F  "   $��0q�66   
�������
������ $��5,1,5,1q�5J      . 6.   5K     5L     �� 5N     $ 
Horizontal=�6   $��0,5,0,0q�66   .+�5O     �� $ 5��6   $��22,0,0,0q�6.   
�������
���   �$��2q�5S  1   $	��112��5U     $��30��6)   ._�5V     �� -   5        $ txtAll��5V  "   $��0q�5X     
�������
������ $��5,1,5,1q�5\      . 6.   5]     5^     5`     5b     �� 5e  
   -   5         ��Name$ AlphaBorder��5e     $��2��6&   $��2��63   
���   �$��60��5g  %   $��2q�5i     $ 5��6%   $��	10,5,10,5q�66   ._�5j     �� -   5         ��Name$ AlphaSlider��5j      �� Orientation$ 
Horizontal=�6*    � Minimum$ 0Q�5l      � Maximum$	 255Q�6    � SmallChange$ 1Q�5n      � LargeChange$ 25Q�6!   $��Center=�5p     $��5q�6,    � Value$	 255Q�5r     5t     5u     5v     5w     