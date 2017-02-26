import random

def main():
    f = open('index.html','w')
    f.write('''<html>
  <head>
    <script src="https://aframe.io/releases/0.5.0/aframe.min.js"></script>
  </head>
  <body>

    <a-scene>
      <a-entity>
      <a-animation attribute="rotation" dur="10000" fill="forwards" to="360 360 360" repeat="indefinite"></a-animation>''')
    for i in range(1000):
        x = str(random.randint(-50, 50))
        y = str(random.randint(-50, 50))
        z = str(random.randint(-50, 50))
        r = str(random.randint(0, 255))
        g = str(random.randint(0, 255))
        b = str(random.randint(0, 255))
        ri = str(random.uniform(.10,.60))
        f.write('<a-sphere position="%s %s %s" radius="%s" color="rgb(%s,%s,%s)"></a-sphere>'%(x, y, z,ri,r,g,b))
    f.write('''
    </a-entity>

       <a-sky color="#000000"></a-sky>
       <a-entity position="0 0 3.8">
         <a-camera></a-camera>
       </a-entity>
    </a-scene>
  </body>
</html>
''')
    f.close()

main()
