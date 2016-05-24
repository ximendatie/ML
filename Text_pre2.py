#coding:utf-8      svm
from __future__ import division  
#import xml.etree.ElementTree as ET
import nltk
from numpy import *
import operator
from nltk.corpus import stopwords
#from nltk.classify import SklearnClassifier
#from sklearn.svm import SVC
import ner
import re
import sys

#delete the lable
def getData1():

    f1=open('index.index')
    s=f1.read();

    re_script=re.compile('<\s*script[^>]*>[^<]*<\s*/\s*script\s*>',re.I)#Script
    re_style=re.compile('<\s*style[^>]*>[^<]*<\s*/\s*style\s*>',re.I)#style
    re_h=re.compile('<(.|\n)*?>')#HTML标签
    re_comment=re.compile('<!--.*-->')#HTML注释
    re_nbsp=re.compile('&nbsp')#HTML注释

    #都替换为空格
    s=re_comment.sub(' ',s)#去掉HTML注释
    s=re_script.sub(' ',s) #去掉SCRIPT
    s=re_style.sub(' ',s)#去掉style
    s=re_h.sub(' ',s) #去掉HTML 标签
    s=re_nbsp.sub(' ',s)

   #去掉多余的空白字符
    blank=re.compile('[\s]+')
    s=blank.sub(' ',s)

    f2= open('b1.txt','w')
    f2.write(s)
    f1.close()
    f2.close()
    return s



#文本处理-Stopword
def getData2():

    f1= open('b1.txt')
    word_list=f1.read();
    myStopwords=[',','.','?','(',')','!','&','$','/',':','%',';','#','@','*','^','|','[',']','{','}','+','=','-']
    word_list = nltk.word_tokenize(word_list)
    word_list = [w for w in word_list if not w in stopwords.words('english')]
    word_list = [w for w in word_list if not w in myStopwords]

    f2= open('b2.txt','w')
    sep =' '
    f2.write(sep.join(word_list))
    f2.close()
    f1.close()
    return word_list




if __name__=="__main__":
    sentenceList=getData1()
    sentenceList=getData2()
    #print sentenceList



