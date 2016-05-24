from bs4 import BeautifulSoup
import sys


reload(sys)
sys.setdefaultencoding('utf-8')


def getData1():
	f1=open('index.html')
	s=f1.read()
	soup=BeautifulSoup(s)
	#print(soup.prettify())

	f2=open('test-index.html','w')
	f2.write(soup.get_text())

	f1.close()
	f2.close()
	return

if __name__=="__main__":
	getData1()