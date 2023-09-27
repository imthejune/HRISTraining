if (typeof Array.isArray === "undefined") {
  Array.isArray = function (obj) {
    return Object.prototype.toString.call(obj) === "[object Array]";
  };
}

var WPMain = (function () {
  return {
    isDev(t) {
      let url = "";
      let status = true;

      if (t) {
        url = t;
      } else {
        url = location.origin;
      }

      if (
        url.indexOf("192.168") > -1 ||
        url.indexOf("localhost:") > -1 ||
        url.indexOf("localhost") > -1
      ) {
        if (url.indexOf("https://") > -1) {
          url = url.toString().replace("https://", "http://");
        }
      } else {
        status = false;
      }

      return {
        url: url,
        status: status,
      };
    },
    /**
     *  Find - data s
     * @param {*} el - Elecment
     * @param {*} query  - attibute
     */
    data(el, query) {
      let ele;

      if (query) {
        ele = el.data()[query];
      } else {
        ele = el.data();
      }

      return ele;
    },
    attr(el, query) {
      let ele;

      if (query) {
        ele = el.attr(query);
      }
      return ele;
    },
    parseHTML(html) {
      var t = document.createElement("template");
      t.innerHTML = html;
      return t.content.cloneNode(true);
    },
    uuid(param) {
      var d = new Date().getTime();
      var d2 =
        (performance && performance.now && performance.now() * 1000) || 0; //Time in microseconds since page-load or 0 if unsupported
      var uuid = "xxxxxxxx".replace(/[xy]/g, function (c) {
        var r = Math.random() * 16;
        if (d > 0) {
          var r = (d + r) % 16 | 0;
          d = Math.floor(d / 16);
        } else {
          var r = (d2 + r) % 16 | 0;
          d2 = Math.floor(d2 / 16);
        }
        return (c == "x" ? r : (r & 0x7) | 0x8).toString(16);
      });
      return uuid;
    },
    bytesToSize(bytes) {
      const sizes = ["Bytes", "KB", "MB", "GB", "TB"];
      if (bytes === 0) return "n/a";
      const i = parseInt(Math.floor(Math.log(bytes) / Math.log(1024)), 10);
      if (i === 0) return `${bytes} ${sizes[i]}`;
      return `${(bytes / 1024 ** i).toFixed(1)} ${sizes[i]}`;
    },
    lastname(e) {
      let type = e.split(".");

      if (type.length > 0) {
        if ($.inArray(type[type.length - 1], self.type) != -1) {
          return {
            status: true,
            lastname: type[type.length - 1],
          };
        } else
          return {
            status: false,
            lastname: type[type.length - 1],
          };
      }
    },
    /**
     *
     * @param {*} object - ary
     * @returns {String} Path - Blob
     * "image/png"
     */
    blob(ary, types) {
      let blobs = new Blob([ary], { type: types });

      if (blobs.size === 0) {
        let arrayBufferView = new Uint8Array(ary);
        blobs = new Blob([arrayBufferView], { type: types });
      }

      let urlCreators = window.URL || window.webkitURL;
      let imageUrl = urlCreators.createObjectURL(blobs);

      return imageUrl ? imageUrl : null;
    },
    request(object, callback) {
      let url = "";

      if (object.url) {
        url = object.url;
      } else {
        console.log("url is empty");
        return false;
      }
      let type = "";

      if (object.type) {
        type = object.type;
      } else {
        type = "post";
      }
      if (!object.onloadend) {
        object.onloadend = function (e) {};
      }

      let data = new FormData();

      if (object.data) {
        data = object.data;
      } else {
        data.append("data", JSON.stringify(object));
      } 

      var self = this;
      
      let req = new XMLHttpRequest();
      req.open("POST", url);
      req.send(data);
      req.onload = function (e) {
        try {
          let obj;
       
          obj = Is.parseData(e.target.response, "");

          callback(obj, null, req);
        } catch (error) {
          console.log("error : " + url, error);
          callback(
            {
              data: error,
              status: 400,
            },
            null,
            req
          );
        }
      };
      req.onloadend = function (e) {
        object.onloadend();
      };

      req.error = function (e) {
        console.log("r", e);
        callback(
          null,
          {
            message: "** An error occurred during the transaction",
          },
          req
        );
      };
    },
    parseData(result, func) {
     
      let check = function (target) {
        let temp;

        if (target.indexOf("{") > -1 && target.indexOf("}") > -1) {
          temp = JSON.parse(target);

          if (!Array.isArray(temp)) {
            if (typeof temp === "object") {
              temp = object(temp);
            } else {
              temp = temp;
            }
          }
        } else if (target.indexOf("[{") > -1 && target.indexOf("}]") > -1) {
          temp = JSON.parse(target);
        } else if (target.indexOf("[]") > -1 || target.indexOf("{}") > -1) {
          temp = JSON.parse(target);
        } else {
          temp = target;
        }

        return temp;
      };

      let object = function (target) {
        $.map(target, (x, y) => {
          if (typeof x === "string") {
            target[y] = check(x);
          } else {
            target[y] = x;
          }
        });

        return target;
      };

      let arry = function (target) {
        let temp;

        if (typeof target === "string") {
          temp = JSON.parse(target);
        } else {
          temp = target;
        }

        if (Array.isArray(temp)) {
          $.map(temp, (x, y) => {
            x = object(x);
          });
        }

        return temp;
      };

      let empty = function (target) {
        let { data, status } = target;

        if (typeof data === "string") {
          if (data.indexOf("[]") > -1) {
            target.data = [];
          } else if (data.indexOf("{}") > -1) {
            target.data = {};
          }
        }
        return target;
      };

      try {

        switch (typeof result) {
          case "object":
            result = result;
            break;

          case "string":
            result = JSON.parse(result);

            break;
        }
     
        
        let { data, status } = result;

        if (data) {
          if (Array.isArray(data)) {
            data = arry(data);
          } else {
            data = check(data);
          }

          result["data"] = data;
          result["status"] = status;

          return result;
        } else {
          return empty(result);
        }
      } catch (error) {
        return {
          data: error.message,
          func: "parseData",
          type: "catch",
          status: "403.2",
        };
      }
    },
    parseObject(doc, func) {
      //   if (typeof doc == 'object') {
      //       return doc;
      //   }

      if (doc.d) {
        if (typeof doc === "string") doc = JSON.parse(doc.d);
      } else {
        if (typeof doc === "string") {
          try {
            doc = JSON.parse(doc);
          } catch (error) {
            return {
              data: doc,
              error: `${error} - ${func} : ${error}`,
              status: 401,
            };
          }
        }
      }

      // Error Call
      if (doc.status != 200) {
        if (doc.data) {
          return {
            data: doc.data,
            error: `${func} : ${doc.data}`,
            status: 401,
          };
        } else {
          return {
            data: doc,
            error: `${func} : ${doc}`,
            status: 401,
          };
        }
      }

      if (func) {
        doc.func = func;
      }

      if (typeof doc.data === "string") {
        if (doc.data === "null") {
          doc.data = [];
        } else {
          if (doc.data.indexOf("{") === -1 || doc.data.indexOf("}") === -1) {
            return doc;
          }
          doc.data = JSON.parse(doc.data);

          let temp_ = [];

          if (doc.data.length > 1) {
            $.map(doc.data, function (element, indexOrKey) {
              if (element && typeof element === "string") {
                doc.data[indexOrKey] = JSON.parse(element);
              }
            });
          } else {
            $.map(doc.data, function (element, indexOrKey) {
              if (element) {
                if (typeof element === "string") {
                  if (element.indexOf("{") > -1 && element.indexOf(":") > -1) {
                    doc.data[indexOrKey] = JSON.parse(element);
                  }
                }
              }
            });
          }
        }
      }

      if (!typeof doc.data === "object") {
        return (doc.data = []);
      }
      return doc;
    },
    sort(obj) {
      let asc = function (key) {
        if (typeof obj != "object") return obj;

        obj.sort(function (a, b) {
          return a[key] > b[key] ? 1 : a[key] < b[key] ? -1 : 0;
        });

        return obj;
      };

      let desc = function (key) {
        if (typeof obj != "object") return obj;

        obj.sort(function (a, b) {
          return b[key] > a[key] ? 1 : b[key] < a[key] ? -1 : 0;
        });

        return obj;
      };

      return {
        asc,
        desc,
      };
    },
    render(page, callback) {
      let parseHTML = function (html) {
        var t = document.createElement("template");
        t.innerHTML = html;
        return t.content.cloneNode(true);
      };
      var parser = new DOMParser();

      $.get(page, function (data, a, b) {
        var root = parser.parseFromString(data, "text/html");

        var contents = root.querySelector("#content");

        callback(b.status != 200 ? false : true, parseHTML(contents.innerHTML));
      });
    },
    urlParams(key) {
      let urlParams = [];

      let match,
        pl = /\+/g, // Regex for replacing addition symbol with a space
        search = /([^&=]+)=?([^&]*)/g,
        decode = function (s) {
          return decodeURIComponent(s.replace(pl, " "));
        },
        query = window.location.search.substring(1);

      while ((match = search.exec(query))) {
        if (decode(match[1]) in urlParams) {
          if (!Array.isArray(urlParams[decode(match[1])])) {
            urlParams[decode(match[1])] = [urlParams[decode(match[1])]];
          }
          urlParams[decode(match[1])].push(decode(match[2]));
        } else {
          urlParams[decode(match[1])] = decode(match[2]);
        }
      }
      if (!key) {
        return urlParams;
      } else {
        return urlParams[key];
      }
    },
    calcTime: function (ele) {
      if (typeof ele != "object") {
        console.log(` warning ${typeof ele} change to 'object' `);
        return false;
      }

      if (!ele.date) {
        console.log(` warning : key - date`);
        return false;
      }
      let format = "T";
      let lang;
      let defaults = {
        T: {
          M: "นาทีที่แล้ว",
          H: "ชั่วโมงที่แล้ว",
          L: "ล่าสุด",
          Y: "เมื่อวาน",
          W: "กี่โมง",
        },
        E: {
          M: "a minute ago",
          H: "an hour ago",
          L: "latest",
          Y: "yesterday",
          W: "what time",
        },
      };

      if (ele.format) {
        format = ele.format;
      }

      lang = defaults[format];

      let dtStart = new Date(ele.date);
      let dtEnd = new Date();

      var _formatDate = function (diff_st, diff_fn) {
        var hours = parseInt(diff / 3600) % 24;
        var minutes = parseInt(diff / 60) % 60;
        var tagTimer;
        var now = new Date();

        if (hours < 24 && hours != 0 && hours != 12) {
          tagTimer = `${hours} ${lang.H} `; //hours + " ชั่วโมงที่แล้ว";
        } else if (hours == 0) {
          tagTimer = `${minutes} ${lang.M} `; // minutes + " นาทีแล้ว";
        } else if (hours == 12 && minutes == 0) {
          if (oldTimer.getFullYear() === now.getFullYear()) {
            tagTimer =
              lang.L + " " + $.datepicker.formatDate("d MM ", oldTimer);
            +" " + lang.W;
          } else {
            tagTimer =
              lang.L + " " + $.datepicker.formatDate("d MM yy", oldTimer);
            +" " + lang.W;
          }
        } else if (hours >= 12 && hours < 48 && hours == 12) {
          tagTimer =
            lang.L +
            " " +
            oldTimer.getHours() +
            ":" +
            oldTimer.getMinutes() +
            " " +
            lang.W;
        }

        return tagTimer;
      };

      var diff = (dtEnd - dtStart) / 1000;
      var totalTime = 0;

      if (diff > 60 * 60 * 12) {
        totalTime = _formatDate(60 * 60 * 12, dtStart);
      } else {
        totalTime = _formatDate(diff, dtStart);
      }
      return totalTime;
    },
    timeDifference(previous) {
      let current = new Date();
      let format = "T";
      let lang;
      let defaults = {
        T: {
          M: "นาทีที่แล้ว",
          H: "ชั่วโมงที่แล้ว",
          L: "ล่าสุด",
          Y: "เมื่อวาน",
          W: "กี่โมง",
        },
        E: {
          M: "a minute ago",
          H: "an hour ago",
          L: "latest",
          Y: "yesterday",
          W: "what time",
        },
      };

      let prevTime = new Date(previous);

      lang = defaults[format];

      var msPerMinute = 60 * 1000;
      var msPerHour = msPerMinute * 60;
      var msPerDay = msPerHour * 24;
      var msPerMonth = msPerDay * 30;
      var msPerYear = msPerDay * 365;

      var elapsed = current - prevTime;

      if (elapsed < msPerMinute) {
        return Math.round(elapsed / 1000) + " seconds ago";
      } else if (elapsed < msPerHour) {
        return Math.round(elapsed / msPerMinute) + " minutes ago";
      } else if (elapsed < msPerDay) {
        return Math.round(elapsed / msPerHour) + " hours ago";
      } else if (elapsed < msPerMonth) {
        return Math.round(elapsed / msPerDay) + " days ago";
      } else if (elapsed < msPerYear) {
        return Math.round(elapsed / msPerMonth) + " months ago";
      } else {
        return Math.round(elapsed / msPerYear) + " years ago";
      }
    },

    wait(states, callback) {
      if (!window.state) {
        return false;
      }

      let chk = false;
      let temp = states;
      let ints = setInterval(() => {
        if (typeof states === "string") {
          if (window.state[states]) {
            chk = true;
          }
        } else if (typeof states === "object") {
          states.map(function (e) {
            if (window.state[e]) {
              temp.pop(e);
            }
          });

          if (temp.length === 0) {
            chk = true;
          }
        } else {
          window.state[states];
        }

        if (chk) {
          callback(chk);
          clearInterval(ints);

          if (typeof states === "string") {
            if (window.state[states]) {
              window.state[states] = !window.state[states];
            }
          } else if (typeof states === "object") {
            states.map(function (e) {
              if (window.state[e]) {
                window.state[e] = !window.state[e];
              }
            });
          }
        } else {
          //callback(chk);
        }
      }, 1000);
    },
    svg(html) {
      let tag = html.querySelectorAll("img.svg");

      tag.forEach(function (img) {
        var imgID = img.id;
        var imgClass = img.className;
        var imgURL = img.src;

        fetch(imgURL)
          .then(function (response) {
            return response.text();
          })
          .then(function (text) {
            var parser = new DOMParser();
            var xmlDoc = parser.parseFromString(text, "text/xml");

            // Get the SVG tag, ignore the rest
            var svg = xmlDoc.getElementsByTagName("svg")[0];

            // Add replaced image's ID to the new SVG
            if (typeof imgID !== "undefined") {
              svg.setAttribute("id", imgID);
            }
            // Add replaced image's classes to the new SVG
            if (typeof imgClass !== "undefined") {
              svg.setAttribute("class", imgClass + " replaced-svg");
            }

            // Remove any invalid XML tags as per http://validator.w3.org
            svg.removeAttribute("xmlns:a");

            // Check if the viewport is set, if the viewport is not set the SVG wont't scale.
            if (
              !svg.getAttribute("viewBox") &&
              svg.getAttribute("height") &&
              svg.getAttribute("width")
            ) {
              svg.setAttribute(
                "viewBox",
                "0 0 " +
                  svg.getAttribute("height") +
                  " " +
                  svg.getAttribute("width")
              );
            }

            // Replace image with new SVG
            img.parentNode.replaceChild(svg, img);
          });
      });
    },
    validate(element, object) {
      let temp = [];

      switch (element) {
        case undefined:
          if (!object) {
            temp.push(`undefined`);
          } else {
            if (object.undefined) {
              temp.push(`undefined`);
            }
          }

          break;

        case null:
          if (!object) {
            temp.push("null");
          } else {
            if (object.null) {
              temp.push("undefined");
            }
          }
          break;
        default:
          switch (typeof element) {
            case "object":
              object.field.forEach(function (k) {
                try {
                  if (k in element) {
                    return;
                  }
                  temp.push(`${k}  doesn't exist in object`);
                } catch (error) {
                  temp.push(error);
                }
              });
              break;
          }
          break;
      }
      if (temp.length > 0) {
        if (object.consoleError) {
          if (object.mesError) {
            temp.map(function (e) {
              console.log(object.mesError, e);
            });
          }
        }
        return Promise.reject(temp);
      } else {
        return Promise.resolve("temp");
      }
    },
  };
})();

if (!window.Is) {
  window.Is = WPMain;
}
