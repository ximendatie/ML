

识别命名实体。使用standford NER -Jan 2009 命名识别工具，可以识别出person organization location misc 【py】(启动不了网上的方法，可能是ner的问题或者需要服务器)
提取URL和Email 并优化【什么语言都行】（去掉停用词之后默认提取出来了，不过已经被淹没，这一步需要提前考虑）
微格提取 获得头衔和地址等【可能是ruby】（暂时没有方法）

文本去掉换行  done
去掉停用词  done
单个文件到 所有文件

特征提取
聚类
