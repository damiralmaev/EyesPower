   M S B A M L   `   `   `  ����D  @EyesPower, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:EyesPower	EyesPower  5   	       EyesPower.SettingsForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:EyesPower     5   	     � Title$#  EysePower: Настройки��5   	    � 
ResizeMode$ NoResize=�6&    � Icon$  Resources\SettingsIcon.ico��6<   $��332.4��6^   $��371.711��6m   .��5	      � .+�5
   
   �� -   5         ��Name$ checkautoload��5
   E    � ToolTip$P JПри запуске системы программа откроется��6   $-��'Автозапуск программы��6\   $
��Left=�6{   $��	10,10,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        $ 	checkhelp��5   =   $A ;Отправление ошибок и статистику��6   $A��;Отправлять нам данные (анонимно)��6P   $
��Left=�6{   $��	10,30,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        $ checkprogram��5   F   $Q KОтключает режим защиты при этих программ��6   $^��XОтключать режим защита глаз при работе программ��6\   $
��Left=�6�   $��	10,50,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        $ checkupdate��5   H   $U OПри новом обновление программа вам сообщит��6   $V��PПроверять обновление при запуске программы��6]   $
��Left=�6�   $��	10,70,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        $ checktraining��5   /   $' !Обычное сообщение��6   $D��>Напонимать о тренировках для глаз��6F   $
��Left=�6r   $��	10,90,0,0q�6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ btsave��5      $��Сохранить��6!   $
��Left=�65   $��281,274,0,0q�6P   $	��Top=�6e   $��75��6}    J� RenderTransformOrigin$ 0.647,1.615&�6�   6�   �� 5   
   -   5        $ 
checkstats��5   @   $E ?Например: Сколько было тренировок?��6   $+��%Включить статистику��6T   $
��Left=�6r   $��
10,109,0,0q�6�   $	��Top=�6�   6�   �� 5   
   -   5        $ 
btstardand��5      $��По умолчанию��6%   $
��Left=�6<   $��150,274,0,0q�6W   $	��Top=�6l   $	��108��6�   $ 0.647,1.615&�6�   6�   5      5      