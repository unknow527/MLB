﻿CREATE TABLE [dbo].[t_kindData] (
    [f_dataId]   INT            IDENTITY (1, 1) NOT NULL,
    [f_kindId]   TINYINT        NOT NULL,
    [f_dataName] NVARCHAR (50)  NOT NULL,
    [f_desc]     NVARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([f_dataId] ASC)
);
--聯盟資料
INSERT INTO [dbo].[t_kindData] ([f_kindId], [f_dataName], [f_desc])
VALUES (2, '美聯', 'American League'),
       (2, '國聯', 'National League'),
       (2, '外卡', 'Wild Card');
--隊伍資料
INSERT INTO [dbo].[t_kindData] ([f_kindId], [f_dataName], [f_desc])
VALUES (1, '水手', 'Mariners'),
(1, '天使', 'Angels'),
(1, '運動家', 'Athletics'),
(1, '遊騎兵', 'Rangers'),
(1, '洋基', 'Yankees'),
(1, '紅襪', 'Red Sox'),
(1, '光芒', 'Rays'),
(1, '藍鳥', 'Blue Jays'),
(1, '金鶯', 'Orioles'),
(1, '皇家', 'Royals'),
(1, '印地安人', 'Indians'),
(1, '老虎', 'Tigers'),
(1, '白襪', 'White Sox'),
(1, '雙城', 'Twins'),
(1, '費城人', 'Phillies'),
(1, '馬林魚', 'Marlins'),
(1, '大都會', 'Mets'),
(1, '國民', 'Nationals'),
(1, '勇士', 'Giants'),
(1, '道奇', 'Dodgers'),
(1, '洛磯', 'Rockies'),
(1, '葛蘭基', 'Padres'),
(1, '菜鳥', 'D-backs'),
(1, '海盜', 'Pirates');

--投手資料
INSERT INTO [dbo].[t_kindData] ([f_kindId], [f_dataName], [f_desc])
VALUES (3, 'Kyle Gibson', null),
       (3, 'Vince Velasquez', null),
       (3, 'Jacob deGrom', null),
       (3, 'Max Scherzer', null),
       (3, 'Gerrit Cole', null),
       (3, 'Walker Buehler', null),
       (3, 'Shohei Ohtani', null),
       (3, 'Tyler Glasnow', null),
       (3, 'Trevor Bauer', null),
       (3, 'Yu Darvish', null),
       (3, 'Clayton Kershaw', null),
       (3, 'Madison Bumgarner', null),
       (3, 'Zack Greinke', null),
       (3, 'Corey Kluber', null),
       (3, 'Chris Sale', null),
       (3, 'Stephen Strasburg', null),
       (3, 'David Price', null),
       (3, 'Félix Hernández', null),
       (3, 'Justin Verlander', null),
       (3, 'CC Sabathia', null),
       (3, 'Jon Lester', null),
       (3, 'Cole Hamels', null),
       (3, 'Tim Lincecum', null),
       (3, 'Matt Cain', null),
       (3, 'Johan Santana', null),
       (3, 'Roy Halladay', null),
       (3, 'Tim Hudson', null),
       (3, 'Mark Buehrle', null),
       (3, 'Curt Schilling', null),
       (3, 'Randy Johnson', null),
       (3, 'Pedro Martínez', null),
       (3, 'Roger Clemens', null),
       (3, 'Greg Maddux', null),
       (3, 'Tom Glavine', null),
       (3, 'John Smoltz', null),
       (3, 'Mike Mussina', null),
       (3, 'Mariano Rivera', null),
       (3, 'Trevor Hoffman', null),
       (3, 'Billy Wagner', null);